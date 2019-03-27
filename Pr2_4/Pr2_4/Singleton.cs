using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pr2_4
{
    public class Singleton
    {
        private static readonly Volume instance = new Volume();

        public string  Name{ get; private set; }
        public int Value { get; private set; }

        private Singleton()
        {
            instance.Name = Name;
            instance.Value = Value;
        }
        public static Volume GetInstance()
        {
            return instance;
        }
    }
}
