@echo off

rem APP_ROOT:ComponentDBサーバのルートディレクトリ
set APP_ROOT="I:\GlobalAssist\PyCharm\ComponentDatabaseService"

rem APP_Python:ComponentDBサーバで使用するPythonがインストールされているディレクトリ
set APP_Python=C:\RsLabEnv\env_component_db

call %APP_Python%\Scripts\activate.bat

tasklist | find "DB_Server" > NUL
if %ERRORLEVEL% == 0 (
  echo DB Serverは起動済みです。
  pause
  goto END
)

echo Start DB Server
cd /d %APP_ROOT%
%APP_Python%\Scripts\python.exe ComponentDatabaseServiceServer.py

pause

:END
