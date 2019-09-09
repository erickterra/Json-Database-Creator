using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Serializable]
    public class Consumable
    {
        public int idItem;
        public int fome;
        public int sede;
        public int cansaco;
        public int saude;
        public bool canned;

    public Consumable(int idItem, int fome, int sede, int cansaco, int saude, bool canned)
    {
        this.idItem = idItem;
        this.fome = fome;
        this.sede = sede;
        this.cansaco = cansaco;
        this.saude = saude;
        this.canned = canned;
    }
}


