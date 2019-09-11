using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Json_Database_Creator
{
    public partial class Form2 : Form
    {
        JsonHandler jsonHandler = new JsonHandler();
        JsonDictionary jsonDictionary;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            jsonDictionary = jsonHandler.ReadJson();

            for (int i = 0; i < jsonDictionary.database.Count; i++)
            {
                comboBox1.Items.Add(jsonDictionary.database[i].itemID.ToString());
            }

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(comboBox1.Text);

            nameText.Text = jsonDictionary.database[id].itemName;
            descricaoTextBox.Text = jsonDictionary.database[id].itemDesc;
            typeComboBox.Text = jsonDictionary.database[id].itemType;
            itemStackBox.Checked = jsonDictionary.database[id].itemStack;
            stackNumericUpDown.Value = jsonDictionary.database[id].itemMaxStack;
            raridadeComboBox.Text = jsonDictionary.database[id].itemRarity;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(comboBox1.Text);

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
                jsonDictionary.database[id].itemName = nameText.Text;
                jsonDictionary.database[id].itemDesc = descricaoTextBox.Text;
                jsonDictionary.database[id].itemStack = itemStackBox.Checked;
                jsonDictionary.database[id].itemMaxStack = (int)stackNumericUpDown.Value;
                jsonDictionary.database[id].itemRarity = raridadeComboBox.Text;
                string type = typeComboBox.Text;
                //bool edit = false;
                switch (type)
                {
                    case "Consumable":
                        Consumables cons = new Consumables(id, jsonDictionary, true);
                        ClearFields();
                        cons.ShowDialog();
                        break;

                    case "Armor":
                        frmArmor arm = new frmArmor(id, jsonDictionary);
                        ClearFields();
                        arm.ShowDialog();
                        break;
                    case "Weapon":
                        FrmWeapon weap = new FrmWeapon(id, jsonDictionary);
                        ClearFields();
                        weap.ShowDialog();
                        break;


                }


            }
            
        }
        private void ClearFields()
        {
            comboBox1.Text = "";
            nameText.Text = "";
            descricaoTextBox.Text = "";
            typeComboBox.SelectedIndex = -1;
            itemStackBox.Checked = false;
            stackNumericUpDown.Value = 1;
            stackNumericUpDown.Enabled = false;
            raridadeComboBox.SelectedIndex = -1;
        }

        private void ItemStackBox_CheckedChanged(object sender, EventArgs e)
        {
            if (itemStackBox.Checked)
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
