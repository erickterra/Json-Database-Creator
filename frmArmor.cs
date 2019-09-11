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
    public partial class frmArmor : Form
    {
        private int idItem;
        private JsonDictionary jd;
        private bool editing;
        private JsonHandler jsonHandler = new JsonHandler();
        public frmArmor(int id, JsonDictionary jsonDictionary, bool editing)
        {
            InitializeComponent();
            idItem = id;
            jd = jsonDictionary;
            this.editing = editing;

            if (editing)
            {
                for (int i = 0; i < jd.armors.Count; i++)
                {
                    if (jd.armors[i].idItem == id)
                    {
                        idItem = i;
                        break;
                    }
                }

                comboBox1.Text = jd.armors[idItem].armorType;
                numericUpDown1.Value = jd.armors[idItem].defense;
                numericUpDown2.Value = jd.armors[idItem].speed;
                numericUpDown3.Value = jd.armors[idItem].slots;


            }

        }

        private void FrmArmor_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha o tipo");
            }
            else
            {
                if (!editing)
                {
                    jd.armors.Add(new Armor(idItem, comboBox1.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value));
                }
                else
                {
                    jd.armors[idItem].armorType = comboBox1.Text;
                    jd.armors[idItem].defense = (int)numericUpDown1.Value;
                    jd.armors[idItem].speed = (int)numericUpDown2.Value;
                    jd.armors[idItem].slots = (int)numericUpDown3.Value;
                }

                jsonHandler.GravarJson(jd);
                this.Close();
            }
        }
    }
}
