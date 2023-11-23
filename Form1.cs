using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;
using System.Net;
using System.Linq;
using System.Net.Http;
using System.IO.Compression;
using Spicetify_Installer;

namespace Spicetify_app
{
    public partial class Spicetify : Form
    {
        private string installLogFilePath = Path.Combine(GetDocumentsFolderPath(), CreateDocumentFolder(), "installLog.txt");
        private string uninstallLogFilePath = Path.Combine(GetDocumentsFolderPath(), CreateDocumentFolder(), "uninstallLog.txt");

        
        public Spicetify()
        {
            InitializeComponent();
            CheckSpicetifyInstallation();
        }

        public static string GetDocumentsFolderPath()
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            return documentsPath;
        }

        public static string CreateDocumentFolder() 
        {
            string documentsPath = GetDocumentsFolderPath();
            string installFolder = Path.Combine(documentsPath, "Spicetify Installer");
            Directory.CreateDirectory(installFolder);
            return installFolder;
        }

        private void CheckSpicetifyInstallation()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string localAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            bool isInstalled = Directory.Exists(Path.Combine(appDataPath, "spicetify")) &&
                              Directory.Exists(Path.Combine(localAppDataPath, "spicetify"));

            InstallBTN.Text = isInstalled ? "Update" : "Install";
            UninstallBTN.Text = isInstalled ? "Uninstall" : "Uninstalled";
            InstallBTN.Enabled = true;
            if (UninstallBTN.Text == "Uninstall")
            {
                UninstallBTN.Enabled = true;
            }
            else if (UninstallBTN.Text == "Uninstalled")
            {
                UninstallBTN.Enabled = false;
            }

        }

        public async void InstallBTN_Click(object sender, EventArgs e)
        {
            InstallBTN.Enabled = false;
            InstallationForm installationForm = new InstallationForm();
            installationForm.Show();
            this.Hide();

            File.AppendAllText(installLogFilePath, "Installation started: " + DateTime.Now + Environment.NewLine);

            using (Process process = new Process())
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                process.OutputDataReceived += (s, args) =>
                {
                    if (args.Data != null)
                    {
                        installationForm.UpdateInstallationProgress(args.Data);
                    }
                };

                process.StartInfo = psi;

                process.Start();
                process.BeginOutputReadLine();

                if (InstallBTN.Text == "Update")
                {
                    process.StandardInput.WriteLine("spicetify upgrade");
                    process.StandardInput.WriteLine("spicetify restore");
                    process.StandardInput.WriteLine("spicetify backup");
                    process.StandardInput.WriteLine("spicetify apply");
                }
                else
                {
                    process.StandardInput.WriteLine("iwr -useb https://raw.githubusercontent.com/spicetify/spicetify-cli/master/install.ps1 | iex");
                    process.StandardInput.WriteLine("iwr -useb https://raw.githubusercontent.com/spicetify/spicetify-marketplace/main/resources/install.ps1 | iex");
                }

                process.StandardInput.Close();

                await Task.Run(() =>
                {
                    process.WaitForExit();
                });
            }

            installationForm.LoadingTimer.Enabled = false;
            installationForm.SetInstallationStatus("Success");
            installationForm.EnableOkButton();

            File.AppendAllText(installLogFilePath, "Installation completed: " + DateTime.Now + Environment.NewLine);

            installationForm.StopTimer();

            installationForm.InstallationComplete += (s, args) => {
                CheckSpicetifyInstallation();
                installationForm.Close();
                this.Show();
                InstallBTN.Enabled = true;
                CheckSpicetifyInstallation();
            };
        }

        public async void UninstallBTN_Click(object sender, EventArgs e)
        {
            UninstallBTN.Enabled = false;
            UninstallationForm uninstallationForm = new UninstallationForm();
            uninstallationForm.Show();
            this.Hide();

            File.AppendAllText(uninstallLogFilePath, "Uninstallation started: " + DateTime.Now + Environment.NewLine);

            await Task.Run(() =>
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                Process process = new Process
                {
                    StartInfo = psi
                };

                process.Start();

                process.StandardInput.WriteLine("spicetify restore");
                process.StandardInput.WriteLine("Remove-Item -Path $env:APPDATA\\spicetify -Recurse -Force");
                process.StandardInput.WriteLine("Remove-Item -Path $env:LOCALAPPDATA\\spicetify -Recurse -Force");

                process.StandardInput.Close();

                File.AppendAllText(uninstallLogFilePath, process.StandardOutput.ReadToEnd());

                process.WaitForExit();
                process.Close();
            });

            uninstallationForm.LoadingTimer.Enabled = false;
            uninstallationForm.SetInstallationStatus("Success");
            uninstallationForm.EnableOkButton();

            File.AppendAllText(uninstallLogFilePath, "Uninstallation completed: " + DateTime.Now + Environment.NewLine);

            uninstallationForm.StopTimer();

            uninstallationForm.UninstallationComplete += (s, args) => {
                CheckSpicetifyInstallation();
                uninstallationForm.Close();
                this.Show();
                UninstallBTN.Enabled = true;
                CheckSpicetifyInstallation();
            };
        }

        private void siticoneGradientCircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://spicetify.app/docs/getting-started");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/spicetify");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.com/invite/VnevqPp2Rr");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.reddit.com/r/spicetify");
        }

        private void Spicetify_Load(object sender, EventArgs e)
        {
            CheckSpicetifyInstallation();
        }
    }
}