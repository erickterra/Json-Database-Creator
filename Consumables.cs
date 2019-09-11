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
        bool editing;

        public Consumables(int id, JsonDictionary dictionary, bool editing)
        {
            this.idItem = id;
            this.jsonDictionary = dictionary;
            this.editing = editing;
            InitializeComponent();

            if (editing)
            {
                for (int i = 0; i < jsonDictionary.consumables.Count; i++)
                {
                    if (jsonDictionary.consumables[i].idItem == id)
                    {
                        this.idItem = i;
                        break;
                    }
                }
                fomeUpDown.Value = jsonDictionary.consumables[idItem].fome;
                sedeUpDown.Value = jsonDictionary.consumables[idItem].sede;
                cansacoUpDown.Value = jsonDictionary.consumables[idItem].cansaco;
                saudeUpDown.Value = jsonDictionary.consumables[idItem].saude;
                cannedCheck.Checked = jsonDictionary.consumables[idItem].canned;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!editing)
            {
                jsonDictionary.consumables.Add(new Consumable(idItem, int.Parse(fomeUpDown.Value.ToString()), int.Parse(sedeUpDown.Value.ToString()), int.Parse(cansacoUpDown.Value.ToString()), int.Parse(saudeUpDown.Value.ToString()), cannedCheck.Checked));
            }
            else
            {
                jsonDictionary.consumables[idItem].fome = (int)fomeUpDown.Value;
                jsonDictionary.consumables[idItem].sede = (int)sedeUpDown.Value;
                jsonDictionary.consumables[idItem].cansaco = (int)cansacoUpDown.Value;
                jsonDictionary.consumables[idItem].saude = (int)saudeUpDown.Value;
                jsonDictionary.consumables[idItem].canned = cannedCheck.Checked;
            }
            jsonHandler.GravarJson(jsonDictionary);
            this.Close();

        }

        private void Consumables_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
