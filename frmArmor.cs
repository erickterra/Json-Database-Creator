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
        private JsonHandler jsonHandler = new JsonHandler();
        public frmArmor(int id, JsonDictionary jsonDictionary)
        {
            InitializeComponent();
            idItem = id;
            jd = jsonDictionary;
            
        }

        private void FrmArmor_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha o tipo");
            }
            else
            {
                jd.armors.Add(new Armor(idItem, comboBox1.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value));
                jsonHandler.GravarJson(jd);
                this.Close();
            }
        }
    }
}
