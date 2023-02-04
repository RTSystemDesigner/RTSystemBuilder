"""
T_COMPONENTテーブル定義
"""
from globals import db, BaseModel
from sqlalchemy import Column, Integer, String, Float, DateTime

class TComponent(BaseModel):
    """
    DB:T_COMPONENTテーブル定義
    """
    __tablename__ = "t_component"
    id = Column('id', Integer, primary_key=True, autoincrement=True)

    name = Column('name', String, nullable=False)
    component_name = Column('component_name', String, nullable=False)
    vendor = Column('vendor', String, nullable=False)
    language = Column('language', Integer, nullable=False)
    repository = Column('repository', String, nullable=False)
    comment = Column('comment', String, nullable=False)
