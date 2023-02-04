# -*- coding: utf-8 -*-

from concurrent.futures import ThreadPoolExecutor

import yaml
import os
import os, shutil

import grpc
import ComponentDB_pb2
import ComponentDB_pb2_grpc

from sqlalchemy import and_, or_, not_

from globals import db, session
from models.t_component import TComponent
from models.t_category import TCategory
from models.t_data_port import TDataPort
from models.t_service_port import TServicePort
from models.t_service_interface import TServiceInterface

from constant import ConstantStatus, ConstantServer

from protobuf_to_dict import protobuf_to_dict, dict_to_protobuf

class ComponentDatabaseServiceManager(ComponentDB_pb2_grpc.ComponentDatabaseServiceServicer):
  """
  """
  def __init__(self):
    pass

  def RegistComponent(self, request, context):
    try:
      params = protobuf_to_dict(request)

      if 'component' not in params.keys():
        return ComponentDB_pb2.StatusResponse(status=ConstantStatus.STATUS_ERR_NOT_COMPONENT,
                                                message='component tag is NOT specified.')
      param_comp = params['component']

      if 'name' not in param_comp.keys():
        return ComponentDB_pb2.StatusResponse(status=ConstantStatus.STATUS_ERR_NOT_NAME_COMPONENT,
                                                message='name tag is NOT specified.')
      if 'vendor' not in param_comp.keys():
        return ComponentDB_pb2.StatusResponse(status=ConstantStatus.STATUS_ERR_NOT_VENDOR_COMPONENT,
                                                message='vendor tag is NOT specified.')
      if 'language' not in param_comp.keys():
        return ComponentDB_pb2.StatusResponse(status=ConstantStatus.STATUS_ERR_NOT_LANGUAGE_COMPONENT,
                                                message='language tag is NOT specified.')
      if 'repository' not in param_comp.keys():
        return ComponentDB_pb2.StatusResponse(status=ConstantStatus.STATUS_ERR_NOT_REPOSITORY_COMPONENT,
                                                message='repository tag is NOT specified.')

      query = session.query(TComponent).filter(
        TComponent.name == param_comp['name'],
        TComponent.repository == param_comp['repository']
      )
      component_list = query.order_by(TComponent.id).all()
      if 0 < len(component_list):
        return ComponentDB_pb2.StatusResponse(status=ConstantStatus.STATUS_ERR_NOT_REPOSITORY_COMPONENT,
                                                message='target alrerady EXISTS.')

      t_component = TComponent()
      t_component.name = param_comp['name']
      t_component.component_name = param_comp['component_name']
      t_component.vendor = param_comp['vendor']
      t_component.language = param_comp['language']
      t_component.repository = param_comp['repository']
      t_component.comment = param_comp['comment']

      session.add(t_component)
      session.commit()

      if 'categories' in param_comp.keys():
        cates = param_comp['categories']
        for each in cates:
          if 'name' not in each.keys():
            session.delete(t_component)
            session.commit()
            return ComponentDB_pb2.StatusResponse(status=ConstantStatus.STATUS_ERR_NOT_NAME_CATEGORY,
                                                  message='name tag is NOT specified.')
          t_catedory = TCategory()
          t_catedory.component_id = t_component.id
          t_catedory.name = each['name']
          if 'parent_id' in each.keys():
            t_catedory.parent_id = each['parent_id']

          session.add(t_catedory)
          session.commit()

      if 'data_ports' in param_comp.keys():
        data_ports = param_comp['data_ports']
        for each in data_ports:
          if 'name' not in each.keys():
            session.delete(t_component)
            session.commit()
            return ComponentDB_pb2.StatusResponse(status=ConstantStatus.STATUS_ERR_NOT_NAME_DATAPORT,
                                                  message='name tag is NOT specified.')
          if 'type' not in each.keys():
            session.delete(t_component)
            session.commit()
            return ComponentDB_pb2.StatusResponse(status=ConstantStatus.STATUS_ERR_NOT_TYPE_DATAPORT,
                                                  message='type tag is NOT specified.')
          if 'direction' not in each.keys():
            session.delete(t_component)
            session.commit()
            return ComponentDB_pb2.StatusResponse(status=ConstantStatus.STATUS_ERR_NOT_DIRECTION_DATAPORT,
                                                  message='direction tag is NOT specified.')

          t_data_port = TDataPort()
          t_data_port.component_id = t_component.id
          t_data_port.name = each['name']
          t_data_port.type = each['type']
          t_data_port.direction = each['direction']

          session.add(t_data_port)
          session.commit()

      if 'service_ports' in param_comp.keys():
        service_ports = param_comp['service_ports']
        for each in service_ports:
          if 'name' not in each.keys():
            session.delete(t_component)
            session.commit()
            return ComponentDB_pb2.StatusResponse(status=ConstantStatus.STATUS_ERR_NOT_NAME_SERVICEPORT,
                                                  message='name tag is NOT specified.')

          t_service_port = TServicePort()
          t_service_port.component_id = t_component.id
          t_service_port.name = each['name']

          session.add(t_service_port)
          session.commit()

          if 'interfaces' in each.keys():
            service_ifs = each['interfaces']
            for each_if in service_ifs:
              if 'name' not in each_if.keys():
                session.delete(t_component)
                session.commit()
                return ComponentDB_pb2.StatusResponse(status=ConstantStatus.STATUS_ERR_NOT_NAME_SERVICEIF,
                                                      message='name tag is NOT specified.')
              if 'direction' not in each_if.keys():
                session.delete(t_component)
                session.commit()
                return ComponentDB_pb2.StatusResponse(status=ConstantStatus.STATUS_ERR_NOT_DIRECTION_SERVICEIF,
                                                      message='direction tag is NOT specified.')
              if 'interface_type' not in each_if.keys():
                session.delete(t_component)
                session.commit()
                return ComponentDB_pb2.StatusResponse(status=ConstantStatus.STATUS_ERR_NOT_TYPE_SERVICEIF,
                                                      message='interface_type tag is NOT specified.')

              t_service_if = TServiceInterface()
              t_service_if.service_port_id = t_service_port.id
              t_service_if.name = each_if['name']
              t_service_if.direction = each_if['direction']
              t_service_if.interface_type = each_if['interface_type']

              session.add(t_service_if)
              session.commit()

      return ComponentDB_pb2.StatusResponse(status=ConstantStatus.STATUS_OK)
    except Exception as ex:
      session.delete(t_component)
      session.commit()
      return ComponentDB_pb2.StatusResponse(status=ConstantStatus.STATUS_NG, message=str(ex))

  def SearchComponent(self, request, context):
    try:
      params = protobuf_to_dict(request)

      names = []
      names_or = False
      categories = []
      category_or = False
      vendor = []
      vendor_or = False
      language = []
      comments = []
      comments_or = False

      data_port_type = []
      data_port_type_or = False
      data_port_direction = []
      service_interface_type = []
      service_interface_type_or = False
      service_interface_direction = []

      if 'names' in params.keys():
        names = params['names']
      if 'names_or' in params.keys():
        names_or = params['names_or']

      if 'categories' in params.keys():
        categories = params['categories']
      if 'categories_or' in params.keys():
        category_or = params['categories_or']

      if 'vendors' in params.keys():
        vendor = params['vendors']
      if 'vendors_or' in params.keys():
        vendor_or = params['vendors_or']

      if 'languages' in params.keys():
        language = params['languages']

      if 'comments' in params.keys():
        comments = params['comments']
      if 'comments_or' in params.keys():
        comments_or = params['comments_or']

      if 'data_port_types' in params.keys():
        data_port_type = params['data_port_types']
      if 'data_port_type_or' in params.keys():
        data_port_type_or = params['data_port_type_or']
      if 'data_port_directions' in params.keys():
        data_port_direction = params['data_port_directions']

      if 'service_interface_types' in params.keys():
        service_interface_type = params['service_interface_types']
      if 'service_interface_type_or' in params.keys():
        service_interface_type_or = params['service_interface_type_or']
      if 'service_interface_directions' in params.keys():
        service_interface_direction = params['service_interface_directions']

      query = session.query(TComponent)
      if 0 < len(names):
        query_name = []
        for each in names:
          if len(each) == 0:
            continue
          query_name.append(TComponent.categories.any(TComponent.name.like("%" + each + "%")))
        if 0 < len(query_name):
          if names_or is True:
            query = query.filter(or_(*query_name))
          else:
            query = query.filter(and_(*query_name))

      if 0 < len(vendor):
        query_vendor = []
        for each in vendor:
          if len(each) == 0:
            continue
          query_vendor.append(TComponent.vendor.like("%" + each + "%"))
        if 0 < len(query_vendor):
          if vendor_or is True:
            query = query.filter(or_(*query_vendor))
          else:
            query = query.filter(and_(*query_vendor))

      if 0 < len(language):
        query_lang = []
        for each in language:
          query_lang.append(TComponent.language == each)
        query = query.filter(or_(*query_lang))

      if 0 < len(comments):
        query_comment = []
        for each in comments:
          if len(each) == 0:
            continue
          query_comment.append(TComponent.categories.any(TComponent.comment.like("%" + each + "%")))
        if 0 < len(query_comment):
          if comments_or is True:
            query = query.filter(or_(*query_comment))
          else:
            query = query.filter(and_(*query_comment))

      if 0 < len(categories):
        query_category = []
        for each in categories:
          if len(each) == 0:
            continue
          query_category.append(TComponent.categories.any(TCategory.name.like("%" + each + "%")))
        if 0 < len(query_category):
          if category_or is True:
            query = query.filter(or_(*query_category))
          else:
            query = query.filter(and_(*query_category))

      if 0 < len(data_port_type):
        query_data_port_type = []
        for each in data_port_type:
          if len(each) == 0:
            continue
          query_data_port_type.append(TComponent.dataports.any(TDataPort.type.like("%" + each + "%")))
        if 0 < len(query_data_port_type):
          if data_port_type_or is True:
            query = query.filter(or_(*query_data_port_type))
          else:
            query = query.filter(and_(*query_data_port_type))

      if 0 < len(data_port_direction):
        query_data_port_direction = []
        for each in data_port_direction:
          query_data_port_direction.append(TComponent.dataports.any(TDataPort.direction == each))
        if 0 < len(query_data_port_direction):
            query = query.filter(or_(*query_data_port_direction))

      if 0 < len(service_interface_type):
        query_service_interface_type = []
        for each in service_interface_type:
          if len(each) == 0:
            continue
          query_service_interface_type.append(TComponent.serviceports.any(TServicePort.serviceinterfaces.any(TServiceInterface.interface_type.like("%" + each + "%"))))
        if 0 < len(query_service_interface_type):
          if service_interface_type_or is True:
            query = query.filter(or_(*query_service_interface_type))
          else:
            query = query.filter(and_(*query_service_interface_type))

      if 0 < len(service_interface_direction):
        query_service_interface_direction = []
        for each in service_interface_direction:
          query_service_interface_direction.append(TComponent.serviceports.any(TServicePort.serviceinterfaces.any(TServiceInterface.direction == each)))
        if 0 < len(query_service_interface_direction):
            query = query.filter(or_(*query_service_interface_direction))

      component_list = query.order_by(TComponent.id).all()

      result = []
      for each in component_list:
        component = ComponentDB_pb2.ComponentInfo()
        component.id = each.id
        component.name = each.name
        component.component_name = each.component_name
        component.vendor = each.vendor
        component.language = each.language
        component.repository = each.repository
        component.comment = each.comment
        result.append(component)

        for each_cat in each.categories:
          category = ComponentDB_pb2.CategoryInfo()
          category.name = each_cat.name
          if each_cat.parent_id is not None:
            category.parent_id = each_cat.parent_id
          component.categories.append(category)

        for each_dp in each.dataports:
          port = ComponentDB_pb2.DataPortInfo()
          port.name = each_dp.name
          port.type = each_dp.type
          port.direction = each_dp.direction
          component.data_ports.append(port)

        for each_sp in each.serviceports:
          port = ComponentDB_pb2.ServicePortInfo()
          port.name = each_dp.name
          for each_si in each_sp.serviceinterfaces:
            sif = ComponentDB_pb2.ServiceInterfaceInfo()
            sif.name = each_si.name
            sif.direction = each_si.direction
            sif.interface_type = each_si.interface_type
            port.interfaces.append(sif)
          component.service_ports.append(port)

      return ComponentDB_pb2.ComponentSearchResponse(results=result)
    except Exception as ex:
      return ComponentDB_pb2.ComponentSearchResponse()

  def UpdateComponent(self, request, context):
    try:
      params = protobuf_to_dict(request)

      if 'component_id' not in params.keys():
        return ComponentDB_pb2.StatusResponse(status=ConstantStatus.STATUS_ERR_NOT_COMPONENT_ID,
                                                message='component_id tag is NOT specified.')
      param_comp_id = params['component_id']

      if 'component' not in params.keys():
        return ComponentDB_pb2.StatusResponse(status=ConstantStatus.STATUS_ERR_NOT_COMPONENT,
                                                message='component tag is NOT specified.')
      param_comp = params['component']

      if 'update_detail' not in params.keys():
        param_update = False
      else:
        param_update = params['update_detail']

      t_component = session.query(TComponent).get(param_comp_id)
      if t_component is None:
        return ComponentDB_pb2.StatusResponse(status=ConstantStatus.STATUS_ERR_COMPONENT_NOT_EXIST,
                                              message='Target component NOT exists.')

      query = session.query(TComponent).filter(
        TComponent.name == param_comp['name'],
        TComponent.repository == param_comp['repository']
      )
      component_list = query.order_by(TComponent.id).all()
      if 0 < len(component_list):
        if component_list[0].id != param_comp_id:
          return ComponentDB_pb2.StatusResponse(status=ConstantStatus.STATUS_ERR_NOT_REPOSITORY_COMPONENT,
                                                  message='target alrerady EXISTS.')

      t_component.name = param_comp['name']
      t_component.comment = param_comp['comment']

      if param_update is True:
        for each in t_component.categories:
          session.delete(each)
        if 'categories' in param_comp.keys():
          cates = param_comp['categories']
          for each in cates:
            if 'name' not in each.keys():
              continue
            t_catedory = TCategory()
            t_catedory.component_id = t_component.id
            t_catedory.name = each['name']
            if 'parent_id' in each.keys():
              t_catedory.parent_id = each['parent_id']

            session.add(t_catedory)
        ###
        for each in t_component.dataports:
          session.delete(each)
        if 'data_ports' in param_comp.keys():
          data_ports = param_comp['data_ports']
          for each in data_ports:
            if 'name' not in each.keys():
              continue
            if 'type' not in each.keys():
              continue
            if 'direction' not in each.keys():
              continue

            t_data_port = TDataPort()
            t_data_port.component_id = t_component.id
            t_data_port.name = each['name']
            t_data_port.type = each['type']
            t_data_port.direction = each['direction']

            session.add(t_data_port)
        session.commit()
        ###
        for each in t_component.serviceports:
          session.delete(each)
        if 'service_ports' in param_comp.keys():
          service_ports = param_comp['service_ports']
          for each in service_ports:
            if 'name' not in each.keys():
              continue

            t_service_port = TServicePort()
            t_service_port.component_id = t_component.id
            t_service_port.name = each['name']

            session.add(t_service_port)
            session.commit()

            if 'interfaces' in each.keys():
              service_ifs = each['interfaces']
              for each_if in service_ifs:
                if 'name' not in each_if.keys():
                  continue
                if 'direction' not in each_if.keys():
                  continue
                if 'interface_type' not in each_if.keys():
                  continue

                t_service_if = TServiceInterface()
                t_service_if.service_port_id = t_service_port.id
                t_service_if.name = each_if['name']
                t_service_if.direction = each_if['direction']
                t_service_if.interface_type = each_if['interface_type']

                session.add(t_service_if)

      session.commit()

      return ComponentDB_pb2.StatusResponse(status=ConstantStatus.STATUS_OK)
    except Exception as ex:
      return ComponentDB_pb2.StatusResponse(status=ConstantStatus.STATUS_NG,
                                              message=str(ex))

  def DeleteComponent(self, request, context):
    try:
      params = protobuf_to_dict(request)
      component_id = params['component_id']
      t_component = session.query(TComponent).get(component_id)
      if t_component is None:
        return ComponentDB_pb2.StatusResponse(status=ConstantStatus.STATUS_ERR_COMPONENT_NOT_EXIST,
                                              message='Target component NOT exists.')
      session.delete(t_component)
      session.commit()

      return ComponentDB_pb2.StatusResponse(status=ConstantStatus.STATUS_OK)
    except Exception as ex:
      return ComponentDB_pb2.StatusResponse(status=ConstantStatus.STATUS_NG,
                                              message=str(ex))

def startServer():
  port_no = 50200

  setting_file = os.path.join(os.path.dirname(__file__), 'ServerSetting.yaml')
  with open(setting_file) as file:
    setting_dict = yaml.safe_load(file)
    if 'PortNumber' in setting_dict.keys():
      port_no = setting_dict['PortNumber']

  # server = grpc.server(ThreadPoolExecutor(max_workers=2))
  server = grpc.server(
              ThreadPoolExecutor(
                max_workers = ConstantServer.WORKER_NUM),
                options = [
                  ('grpc.max_send_message_length', ConstantServer.MESSAGE_SIZE),
                  ('grpc.max_receive_message_length', ConstantServer.MESSAGE_SIZE)
                ]
            )

  ComponentDB_pb2_grpc.add_ComponentDatabaseServiceServicer_to_server(ComponentDatabaseServiceManager(), server)
  server.add_insecure_port('[::]:' + str(port_no))
  server.start()

  server.wait_for_termination()

if __name__ == '__main__':
  startServer()