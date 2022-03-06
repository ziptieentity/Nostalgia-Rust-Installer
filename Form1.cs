using System.Diagnostics;

namespace NRInstaller
{
    public partial class NRInstaller : Form
    {
        public NRInstaller()
        {
            InitializeComponent();
        }

        private void client_Click(object sender, EventArgs e)
        {
            if (clientPath.ShowDialog() == DialogResult.OK)
            {
                if (clientPath.SelectedPath != null)
                {
                    label1.Text = $"Install Location: {clientPath.SelectedPath}";
                    installClient.Enabled = true;
                }
            }
        }
        private void server_Click(object sender, EventArgs e)
        {
            if (serverPath.ShowDialog() == DialogResult.OK)
            {
                if (serverPath.SelectedPath != null)
                {
                    label2.Text = $"Install Location: {serverPath.SelectedPath}";
                    installServer.Enabled = true;
                }
            }
        }
        private void installClient_Click(object sender, EventArgs e)
        {
            var text = @$"
@echo off
set /p username=""Enter Steam username: ""
echo. 
set /p password=""Enter Steam password: ""
mkdir {clientPath.SelectedPath}\Client
set clientdir={clientPath.SelectedPath}\Client
timeout 2 > nul
echo.
echo Installing client. Please do not close this window even if it appears frozen...
timeout 2 > nul
%cd%\DepotManager\DepotDownloader.exe .\DepotDownloader.exe -app 252490 -depot 252495 -manifest 6056132920533103204 -username %username% -password %password% -dir %clientdir% -remember-password
%cd%\DepotManager\DepotDownloader.exe .\DepotDownloader.exe -app 252490 -depot 252494 -manifest 4298157561235388214 -username %username% -password %password% -dir %clientdir% -remember-password
echo Install Complete. This window will close in 5 seconds
timeout 5 > nul

";
            StreamWriter sw = new StreamWriter("client.bat");
            sw.WriteLine(text);
            sw.Dispose();
            System.Diagnostics.Process.Start("client.bat");
        }
        private void installServer_Click(object sender, EventArgs e)
        {
            var text = @$"
@echo off
mkdir {serverPath.SelectedPath}\Server
set clientdir={serverPath.SelectedPath}\Server
timeout 2 > nul
echo.
echo Installing Server. Please do not close this window even if it appears frozen...
timeout 2 > nul
%cd%\DepotManager\DepotDownloader.exe .\DepotDownloader.exe -app 258550 -depot 258551 -manifest 1016325128606548948 -dir %serverdir%
%cd%\DepotManager\DepotDownloader.exe .\DepotDownloader.exe -app 258550 -depot 258554 -manifest 7115587983700353868 -dir %serverdir%
echo Install Complete. This window will close in 5 seconds
timeout 5 > nul

";
            StreamWriter sw = new StreamWriter("server.bat");
            sw.WriteLine(text);
            sw.Dispose();
            System.Diagnostics.Process.Start("server.bat");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}