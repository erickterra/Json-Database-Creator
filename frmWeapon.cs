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
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha o tipo");
            }
            else
            {
                if (!editing)
                {
                    jd.weapons.Add(new Weapons(idItem, comboBox1.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value));
                }
                else
                {
                    jd.weapons[idItem].weaponType = comboBox1.Text;
                    jd.weapons[idItem].attack = (int)numericUpDown1.Value;
                    jd.weapons[idItem].range = (int)numericUpDown2.Value;
                }
                
                jsonHandler.GravarJson(jd);
                this.Close();
            }
        }
    }
}
