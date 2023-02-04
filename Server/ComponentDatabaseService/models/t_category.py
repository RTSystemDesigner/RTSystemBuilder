"""
T_CATEGORYテーブル定義
"""
from globals import db, BaseModel
from sqlalchemy import Column, Integer, String, Float, DateTime
from sqlalchemy.schema import ForeignKey
from sqlalchemy.orm import relationship, backref

class TCategory(BaseModel):
    """
    DB:T_CATEGORYテーブル定義
    """
    __tablename__ = 't_category'
    id = Column('id', Integer, primary_key=True, autoincrement=True)

    component_id = Column('component_id', ForeignKey('t_component.id'), nullable=False)
    category = relationship('TComponent',
                               backref=backref('categories', cascade='all, delete-orphan'))

    parent_id = Column('parent_id', Integer, nullable=False)
    name = Column('name', String, nullable=False)
