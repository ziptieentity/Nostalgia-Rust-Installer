
@echo off
mkdir C:\Users\noahw\Downloads\bin\Server
set clientdir=C:\Users\noahw\Downloads\bin\Server
timeout 2 > nul
echo.
echo Installing Server. Please do not close this window even if it appears frozen...
timeout 2 > nul
%cd%\DepotManager\DepotDownloader.exe .\DepotDownloader.exe -app 258550 -depot 258551 -manifest 1016325128606548948 -dir %serverdir%
%cd%\DepotManager\DepotDownloader.exe .\DepotDownloader.exe -app 258550 -depot 258554 -manifest 7115587983700353868 -dir %serverdir%
echo Install Complete. This window will close in 5 seconds
timeout 5 > nul


