@echo off
set /p username="Enter Steam username: "
echo. 
set /p password="Enter Steam password: "
mkdir ..\Client
set clientdir=..\Client
timeout 2 > nul
echo.
echo Installing client. Please do not close this window even if it appears frozen...
timeout 2 > nul
%cd%..\DepotManager\DepotDownloader.exe .\DepotDownloader.exe -app 252490 -depot 252495 -manifest 6056132920533103204 -username %username% -password %password% -dir %clientdir% -remember-password
%cd%..\DepotManager\DepotDownloader.exe .\DepotDownloader.exe -app 252490 -depot 252494 -manifest 4298157561235388214 -username
echo Install Complete. Closing in 5 seconds...
timeout 5 > nul
