using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hairdressers
{
    public class Buchung
    {

        private int bu_id;    
        private int start_time;
        private int end_time;
        private DateTime date;

        private int mitarbeiter_id;
        private int kunde_id;
        private int haarstil_id;

   public int Bu_id { get => bu_id; set => bu_id = value; }
        public int Start_time { get => start_time; set => start_time = value; }
        public int End_time { get => end_time; set => end_time = value; }
        public DateTime Date { get => date; set => date = value; }

        public int Mitarbeiter_id { get => mitarbeiter_id; set => mitarbeiter_id = value; }
        public int Kunde_id { get => kunde_id; set => kunde_id = value; }
        public int Haarstil_id { get => haarstil_id; set => haarstil_id = value; }

        public Buchung() { }
        public Buchung(int bu_id,  int stime,int etime, DateTime date, int ma_id, int ku_id, int hs_id)
        {
            this.bu_id = bu_id;      
            Start_time = stime ;
           end_time = etime ;
            this.date = date ;

            Mitarbeiter_id= ma_id ;
            Kunde_id= ku_id ;
            Haarstil_id = hs_id ;
        }

      
    }
}
