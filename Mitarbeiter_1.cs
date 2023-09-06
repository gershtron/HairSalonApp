using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hairdressers
{
    public class Haarstil
    {

        private int hs_id;
        private string hs_name;
        private decimal hs_preis;
        private int hs_dauer;

        public int Hs_id { get => hs_id; set => hs_id = value; }
        public string Hs_name { get => hs_name; set => hs_name = value; }
        public decimal Hs_preis { get => hs_preis; set => hs_preis = value; }
        public int Hs_dauer { get => hs_dauer; set => hs_dauer = value; }

        public Haarstil() { }
        public Haarstil(int hs_id, string hs_name, decimal hs_preis, int hs_dauer)
        {
           hs_id = hs_id;
            hs_name = hs_name;
            hs_preis = hs_preis;
            hs_dauer = hs_dauer;
        }







    }
}
