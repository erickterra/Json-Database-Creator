using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            JSonManager js = new JSonManager();
            js.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Globals.directory + Globals.fileName))
            {
                Form2 edit = new Form2();
                edit.ShowDialog();
            }
            else {MessageBox.Show("Não existe nenhum registro no arquivo Json");}
        }
    }
}
