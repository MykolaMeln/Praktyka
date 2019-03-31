using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr5_4_
{
    interface IPersonage
    {
        string TypePersonage();
    }

    class King : IPersonage
    {
        public string TypePersonage()
        {
            return "King";
        }
    }
    class Queen : IPersonage
    {
        public string TypePersonage()
        {
            return "Queen";
        }
    }
    class Knight : IPersonage
    {
        public string TypePersonage()
        {
            return "Knight";
        }
    }
    class Troll : IPersonage
    {
        public string TypePersonage()
        {
            return "Troll";
        }
    }

}
