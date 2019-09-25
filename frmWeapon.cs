using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Json_Database_Creator
{
    public partial class FrmWeapon : Form
    {
        private int idItem;
        private JsonDictionary jd;
        private bool editing;

        private JsonHandler jsonHandler = new JsonHandler();
        public FrmWeapon(int id, JsonDictionary jsonDictionary, bool editing)
        {
            InitializeComponent();
            idItem = id;
            jd = jsonDictionary;
            this.editing = editing;
            if (editing)
            {
                for (int i = 0; i < jd.weapons.Count; i++)
                {
                    if (jd.weapons[i].idItem == id)
                    {
                        idItem = i;
                    }
                }

                comboBox1.Text = jd.weapons[idItem].weaponType;
                numericUpDown1.Value = jd.weapons[idItem].attack;
                numericUpDown2.Value = jd.weapons[idItem].range;
                comboBox2.Text = jd.weapons[idItem].hold;
                numericUpDown3.Value = jd.weapons[idItem].fireRate;
                numericUpDown4.Value = jd.weapons[idItem].reloadSpeed;
                comboBox3.Text = jd.weapons[idItem].ammo;
            }
            
            
        }

        private void FrmWeapon_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox3.Text == "")
            {
                MessageBox.Show("Há campos sem preencher");
            }
            else
            {
                if (!editing)
                {
                    jd.weapons.Add(new Weapons(idItem, comboBox1.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, comboBox2.Text, numericUpDown3.Value, numericUpDown4.Value, comboBox3.Text));
                }
                else
                {
                    jd.weapons[idItem].weaponType = comboBox1.Text;
                    jd.weapons[idItem].attack = (int)numericUpDown1.Value;
                    jd.weapons[idItem].range = (int)numericUpDown2.Value;
                    jd.weapons[idItem].fireRate = numericUpDown3.Value;
                    jd.weapons[idItem].reloadSpeed = numericUpDown4.Value;
                    jd.weapons[idItem].hold = comboBox2.Text;
                    jd.weapons[idItem].ammo = comboBox3.Text;
                }
                
                jsonHandler.GravarJson(jd);
                this.Close();
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Ranged")
            {
                comboBox3.Text = "";
                comboBox3.Enabled = true;
                numericUpDown4.Enabled = true;
            }
            else
            {
                comboBox3.Text = "None";
                comboBox3.Enabled = false;
                numericUpDown4.Value = 0.0M;
                numericUpDown4.Enabled = false;
            }
        }
    }
}
