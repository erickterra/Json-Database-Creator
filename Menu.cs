using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Json_Database_Creator
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(Globals.filePath + Globals.fileName))
            {
                JSonManager JM = new JSonManager();
                JM.ShowDialog();
            }
            else
            {
                JsonHandler jh = new JsonHandler();
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Arquivo Json (*.json)| *.json";
                saveDialog.FilterIndex = 1;
                saveDialog.RestoreDirectory = true;
                JsonDictionary jd = new JsonDictionary();

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo newFile = new FileInfo(saveDialog.FileName);
                    var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var appSettings = ConfigurationManager.AppSettings;

                    configFile.AppSettings.Settings["FILEPATH"].Value = newFile.DirectoryName;
                    configFile.AppSettings.Settings["FILENAME"].Value = newFile.Name;

                    configFile.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");

                    jh.GravarJson(jd);
                    JSonManager JM = new JSonManager();
                    JM.ShowDialog();
                }

            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Globals.filePath + Globals.fileName))
            {
                Form2 edit = new Form2();
                edit.ShowDialog();
            }
            else { MessageBox.Show("Não existe nenhum registro no arquivo Json"); }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            JsonHandler jh = new JsonHandler();
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Arquivo Json (*.json)| *.json";
            saveDialog.FilterIndex = 1;
            saveDialog.RestoreDirectory = true;
            JsonDictionary jd;

            if (File.Exists(Globals.filePath + Globals.fileName))
            {
                jd = jh.ReadJson();
            }
            else
            {
                jd = new JsonDictionary();
            }


            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo newFile = new FileInfo(saveDialog.FileName);
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var appSettings = ConfigurationManager.AppSettings;

                configFile.AppSettings.Settings["FILEPATH"].Value = newFile.DirectoryName;
                configFile.AppSettings.Settings["FILENAME"].Value = newFile.Name;

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                jh.GravarJson(jd);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            JsonHandler jh = new JsonHandler();
            OpenFileDialog saveDialog = new OpenFileDialog();
            saveDialog.Filter = "Arquivo Json (*.json)| *.json";
            saveDialog.FilterIndex = 1;
            saveDialog.RestoreDirectory = true;

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo newFile = new FileInfo(saveDialog.FileName);
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var appSettings = ConfigurationManager.AppSettings;

                configFile.AppSettings.Settings["FILEPATH"].Value = newFile.DirectoryName;
                configFile.AppSettings.Settings["FILENAME"].Value = newFile.Name;

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }

        }
    }
}