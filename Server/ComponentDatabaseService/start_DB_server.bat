@echo off

rem APP_ROOT:ComponentDB�T�[�o�̃��[�g�f�B���N�g��
set APP_ROOT="I:\GlobalAssist\PyCharm\ComponentDatabaseService"

rem APP_Python:ComponentDB�T�[�o�Ŏg�p����Python���C���X�g�[������Ă���f�B���N�g��
set APP_Python=C:\RsLabEnv\env_component_db

call %APP_Python%\Scripts\activate.bat

tasklist | find "DB_Server" > NUL
if %ERRORLEVEL% == 0 (
  echo DB Server�͋N���ς݂ł��B
  pause
  goto END
)

echo Start DB Server
cd /d %APP_ROOT%
%APP_Python%\Scripts\python.exe ComponentDatabaseServiceServer.py

pause

:END
