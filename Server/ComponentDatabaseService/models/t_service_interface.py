"""
T_SERVICE_INTERFACEテーブル定義
"""
from globals import db, BaseModel
from sqlalchemy import Column, Integer, String, Float, DateTime
from sqlalchemy.schema import ForeignKey
from sqlalchemy.orm import relationship, backref

class TServiceInterface(BaseModel):
    """
    DB:T_SERVICE_INTERFACEテーブル定義
    """
    __tablename__ = "t_service_interface"
    id = Column('id', Integer, primary_key=True, autoincrement=True)

    service_port_id = Column('service_port_id', ForeignKey('t_service_port.id'), nullable=False)
    service_interface = relationship('TServicePort',
                               backref=backref('serviceinterfaces', cascade='all, delete-orphan'))

    name = Column('name', String, nullable=False)
    direction = Column('direction', Integer, nullable=False)
    interface_type = Column('interface_type', String, nullable=False)
