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

                switch (type)
                {
                    case "Consumable":
                        Consumables cons = new Consumables(id, jsonDictionary);
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
            nameText.Text = "";
            descricaoTextBox.Text = "";
            typeComboBox.SelectedIndex = -1;
            itemStackBox.Checked = false;
            stackNumericUpDown.Value = 1;
            stackNumericUpDown.Enabled = false;
            raridadeComboBox.SelectedIndex = -1;
        }
    }
}
