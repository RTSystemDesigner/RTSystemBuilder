# -*- coding: utf-8 -*-

from sqlalchemy import create_engine
from sqlalchemy.ext.declarative import declarative_base
from sqlalchemy.orm import sessionmaker

db = create_engine('postgresql://rsdlab:rsdlab@localhost:5432/componentdb')
BaseModel = declarative_base()
SessionClass = sessionmaker(db)
session = SessionClass()

