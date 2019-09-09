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
        private JsonHandler jsonHandler = new JsonHandler();
        public FrmWeapon(int id, JsonDictionary jsonDictionary)
        {
            InitializeComponent();
            idItem = id;
            jd = jsonDictionary;
            
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
                jd.weapons.Add(new Weapons(idItem, comboBox1.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value));
                jsonHandler.GravarJson(jd);
                this.Close();
            }
        }
    }
}
