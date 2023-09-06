using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hairdressers
{
    public class Kunde
    {
        private int kunde_id;
        private string kunde_vorname;
        private string kunde_nachname;
        private int kunde_telefon;



        public int Kunde_id { get => kunde_id; set => kunde_id = value; }
        public string Kunde_vorname { get => kunde_vorname; set => kunde_vorname = value; }
        public string Kunde_nachname { get => kunde_nachname; set => kunde_nachname = value; }
        public int Kunde_telefon { get => kunde_telefon; set => kunde_telefon = value; }

        public Kunde() { }

        public Kunde(int ku_id, string ku_vn, string ku_nn, int ku_tel)
        {
            kunde_id = ku_id;
            kunde_vorname = ku_vn;
            kunde_nachname = ku_nn;
            Kunde_telefon = ku_tel;

        }
}
}
