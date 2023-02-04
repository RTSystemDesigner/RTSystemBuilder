"""
T_DATA_PORTテーブル定義
"""
from globals import db, BaseModel
from sqlalchemy import Column, Integer, String, Float, DateTime
from sqlalchemy.schema import ForeignKey
from sqlalchemy.orm import relationship, backref

class TDataPort(BaseModel):
    """
    DB:T_DATA_PORTテーブル定義
    """
    __tablename__ = "t_data_port"
    id = Column('id', Integer, primary_key=True, autoincrement=True)

    component_id = Column('component_id', ForeignKey('t_component.id'), nullable=False)
    data_port = relationship('TComponent',
                               backref=backref('dataports', cascade='all, delete-orphan'))

    name = Column('name', String, nullable=False)
    type = Column('type', String, nullable=False)
    direction = Column('direction', Integer, nullable=False)
