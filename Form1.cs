using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Json_Database_Creator
{
    public partial class JSonManager : Form
    {
        private string folderPath = Globals.filePath;
        private string fileName = Globals.fileName;
        public string fileType;
        public FileInfo jsonFile;
        public JsonDictionary jsonDictionary = new JsonDictionary();
        JsonHandler jsonHandler = new JsonHandler();

        public JSonManager()
        {
            InitializeComponent();
        }



        private void Submit_Click(object sender, EventArgs e)
        {
            int id;
            if (jsonDictionary.database == null)
            {
                id = 0;
            }
            else
            {
                id = jsonDictionary.database.Count;
            }

            if (
            nameText.Text == "" ||
            descricaoTextBox.Text == "" ||
            typeComboBox.SelectedIndex == -1 || 
            stackNumericUpDown.Value < 1 || 
            raridadeComboBox.SelectedIndex == -1
            )
            {
                MessageBox.Show("Há campos sem preencher");
            }
            else
            {
                jsonDictionary.database.Add(new Item(nameText.Text, id, descricaoTextBox.Text, typeComboBox.Text, itemStackBox.Checked, int.Parse(stackNumericUpDown.Value.ToString()), raridadeComboBox.Text));

                string type = typeComboBox.Text;

                switch(type)
                {
                    case "Consumable":
                        Consumables cons = new Consumables(id, jsonDictionary, false);
                        ClearFields();
                        cons.ShowDialog();
                        break;

                    case "Armor":
                        frmArmor arm = new frmArmor(id, jsonDictionary, false);
                        ClearFields();
                        arm.ShowDialog();
                        break;
                    case "Weapon":
                        FrmWeapon weap = new FrmWeapon(id, jsonDictionary, false);
                        ClearFields();
                        weap.ShowDialog();
                        break;

                    default:
                        jsonHandler.GravarJson(jsonDictionary);
                        break;
                        
                }
                    
                
            }

        }

        private void ClearFields()
        {
            nameText.Text = "";
            descricaoTextBox.Text = "";
            typeComboBox.SelectedIndex= -1;
            itemStackBox.Checked = false;
            stackNumericUpDown.Value = 1;
            stackNumericUpDown.Enabled = false;
            raridadeComboBox.SelectedIndex =-1;
        }

        private void JSonManager_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            if (File.Exists(folderPath + fileName))
            {
                fileType = " *.json";
                DirectoryInfo folder = new DirectoryInfo(folderPath);
                jsonDictionary.database.Clear();
                jsonDictionary.consumables.Clear();
                jsonDictionary.weapons.Clear();
                jsonDictionary.armors.Clear();
                jsonDictionary = jsonHandler.ReadJson();
            }
        }

        private void ItemStackBox_CheckedChanged(object sender, EventArgs e)
        {
            if(itemStackBox.Checked)
            {

                stackNumericUpDown.Enabled = true;
            }
            else
            {
                stackNumericUpDown.Value = 1;
                stackNumericUpDown.Enabled = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}

