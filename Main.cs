using QuickShortCut.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Shortcut = QuickShortCut.Base.Shortcut;

namespace QuickShortCut
{
    public partial class Main : Form
    {
        #region Variable
        public static string StartupShortCut = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + "Startup.lnk";
        public static string StartupLinkPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
        public static string EAPLinkPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + "EAP_Link";
        #endregion
        #region Initialize
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            RDB_Single.Checked = true;
            RDB_Multiple.Checked = false;
            TB_OS_TYPE.Text = OSUtil.GetOSVersion();
            TB_OS_BIT.Text = OSUtil.GetOSArchitecture();
            if (!File.Exists(StartupLinkPath))
                Shortcut.CreateShortcut(StartupLinkPath, StartupShortCut, "");
            if (!Directory.Exists(EAPLinkPath))
                Directory.CreateDirectory(EAPLinkPath);
            //TB_SRC.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + "TEST";
            // C:\Documents and Settings\All Users\Start Menu\Programs\Startup
            // Startup - WIN7
            // C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Startup
            // Startup - WIN8
            // C:\Users\<user>\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup
            // Startup - WIN10
            // C:\Users\<user>\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup
        }
        #endregion
        private void LogTrace(string Message)
        {
            LogHelper.LogTrace(Message);
        }

        #region Button Click Event
        private void BTN_SRC_Click(object sender, EventArgs e)
        {
            try
            {
                TB_SRC.Text = "";
                if (RDB_Single.Checked)
                {
                    using (openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.Title = "Select the excutable file.";
                        openFileDialog.Filter = "Executable file (*.exe)|*.exe";
                        openFileDialog.FilterIndex = 0;
                        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                       if (openFileDialog.ShowDialog() == DialogResult.OK)
                            TB_SRC.Text = openFileDialog.FileName;
                        else
                            TB_SRC.Text = "";
                        LogTrace("File Selected : {" + TB_SRC.Text+"}");
                    }
                }
                else if (RDB_Multiple.Checked)
                {
                    using (folderBrowserDialog = new FolderBrowserDialog())
                    {
                        folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
                        folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        folderBrowserDialog.Description = "Select the root path of the excutable file.";
                        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                            TB_SRC.Text = folderBrowserDialog.SelectedPath;
                        else
                            TB_SRC.Text = "";
                        LogTrace("Dir Selected: {" + TB_SRC.Text + "}");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BTN_CREATE_Click(object sender, EventArgs e)
        {
            string args = "AutoStartup";
            string eapLink = string.Empty;
            string startupLink = string.Empty;
            string fileName = string.Empty;
            string allMessage = string.Empty;
            List<string> getFile = new List<string>();
            try
            {
                if (RDB_Single.Checked)
                {
                    fileName = Path.GetFileNameWithoutExtension(TB_SRC.Text);
                    startupLink = StartupLinkPath + @"\" + fileName + ".lnk";
                    eapLink = EAPLinkPath + @"\" + fileName + ".lnk";
                    if (File.Exists(eapLink))
                        File.Delete(eapLink);
                    if (File.Exists(startupLink))
                        File.Delete(startupLink);
                    Shortcut.CreateShortcut(TB_SRC.Text, EAPLinkPath, args);
                    Shortcut.CreateShortcut(TB_SRC.Text, StartupLinkPath, args);
                    if (TB_SRC.Text.Length > 0)
                    {
                        MessageBox.Show("[" + TB_SRC.Text + "] has been Created Successfully.");
                    }
                }
                else if (RDB_Multiple.Checked)
                {
                    foreach (string file in Directory.GetFiles(TB_SRC.Text.Trim(), "*.exe"))
                    {
                        getFile.Add(file);
                    }
                    foreach (string directory in Directory.GetDirectories(TB_SRC.Text.Trim(), "*", SearchOption.AllDirectories))
                    {
                        foreach (string file in Directory.GetFiles(directory, "*.exe"))
                        {
                            getFile.Add(file);
                        }
                    }
                    getFile.Sort((a, b) => b.Length.CompareTo(a.Length));

                    foreach (string file in getFile)
                    {
                        DirectoryInfo di = new DirectoryInfo(file);
                        fileName = Path.GetFileNameWithoutExtension(file);
                        startupLink = StartupLinkPath + @"\" + fileName + ".lnk";
                        eapLink = EAPLinkPath + @"\" + fileName + ".lnk";
                        if (!File.Exists(eapLink))
                        {
                            Shortcut.CreateShortcut(file, EAPLinkPath, args);
                            allMessage += "[" + file + "] has been Created Successfully. \r\n";
                        }
                        if (!File.Exists(startupLink))
                            Shortcut.CreateShortcut(file, StartupLinkPath, args);
                    }
                    if (allMessage.Length > 0)
                        MessageBox.Show(allMessage);
                    else
                        MessageBox.Show("No shortcut is created.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("It has a problem about the reason that {" + ex.Message + "} .");
            }
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(EAPLinkPath))
                {
                    foreach (string file in Directory.GetFiles(EAPLinkPath, "*.lnk"))
                    {
                        string fileName = StartupLinkPath + @"\" + Path.GetFileName(file);
                        if (File.Exists(fileName))
                            File.Delete(fileName);
                    }
                    Directory.Delete(EAPLinkPath, true);
                    Directory.CreateDirectory(EAPLinkPath);
                }
                else
                {
                    Directory.CreateDirectory(EAPLinkPath);
                }
                MessageBox.Show("It has been removed all of the shortcuts about EAP & Startup");
            }
            catch (Exception ex)
            {
                MessageBox.Show("It has a problem about the reason that {" + ex.Message + "} .");
            }
        }

        #endregion

        #region RadioButton Click Event
        private void RDB_Single_CheckedChanged(object sender, EventArgs e)
        {
            if (RDB_Single.Checked)
            {
                RDB_Single.Checked = true;
                RDB_Multiple.Checked = false;
            }
            TB_SRC.Text = "";
        }
        #endregion

        private void RDB_Multiple_CheckedChanged(object sender, EventArgs e)
        {
            if (RDB_Multiple.Checked)
            {
                RDB_Single.Checked = false;
                RDB_Multiple.Checked = true;
            }
            TB_SRC.Text = "";
        }
    }
}
