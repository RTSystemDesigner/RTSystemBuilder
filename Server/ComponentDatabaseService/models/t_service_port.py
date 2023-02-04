"""
T_DATA_PORTテーブル定義
"""
from globals import db, BaseModel
from sqlalchemy import Column, Integer, String, Float, DateTime
from sqlalchemy.schema import ForeignKey
from sqlalchemy.orm import relationship, backref

class TServicePort(BaseModel):
    """
    DB:T_SERVICE_PORTテーブル定義
    """
    __tablename__ = "t_service_port"
    id = Column('id', Integer, primary_key=True, autoincrement=True)

    component_id = Column('component_id', ForeignKey('t_component.id'), nullable=False)
    service_port = relationship('TComponent',
                               backref=backref('serviceports', cascade='all, delete-orphan'))

    name = Column('name', String, nullable=False)
