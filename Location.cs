using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hairdressers
{
    public class Location
    {

        private int Location_id;
        private string Location_name;
        private string IsOpen;

        public int Location_id1 { get => Location_id; set => Location_id = value; }
        public string Location_name1 { get => Location_name; set => Location_name = value; }
        public string IsOpen1 { get => IsOpen; set => IsOpen = value; }

        public Location() { }

        public Location(int loc_id, string loc_name, string open)
        {
          Location_id = loc_id;
            Location_name = loc_name;
            IsOpen = open;

        }
    }
}
