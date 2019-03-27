using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pr2_4
{
    public class Volume
    {
        public string Name;
        public int Value;
        public Volume() { }
        public Volume(string Name, int Value)
        {
            this.Name = Name;
            this.Value = Value;
        }
        public SettingsDB Changed()
        {
            SettingsDB sdb = new SettingsDB(Name, Value);
            return sdb;
        }


    }
}
