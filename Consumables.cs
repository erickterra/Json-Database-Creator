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

namespace Json_Database_Creator
{
    public partial class Consumables : Form
    {
        private JsonDictionary jsonDictionary;
        private JsonHandler jsonHandler = new JsonHandler();
        private int idItem;

        public Consumables(int id, JsonDictionary dictionary)
        {
            this.idItem = id;
            this.jsonDictionary = dictionary;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            jsonDictionary.consumables.Add(new Consumable(idItem, int.Parse(fomeUpDown.Value.ToString()), int.Parse(sedeUpDown.Value.ToString()), int.Parse(cansacoUpDown.Value.ToString()), int.Parse(saudeUpDown.Value.ToString()), cannedCheck.Checked));
            jsonHandler.GravarJson(jsonDictionary);
            this.Close();
        }

        private void Consumables_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
