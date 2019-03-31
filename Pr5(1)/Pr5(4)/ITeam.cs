using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr5_4_
{
    interface ITeam
    {
        string TypeTeam();
    }

    class Red : ITeam
    {
        public string TypeTeam()
        {
            return "Red";
        }
    }  
    class Green : ITeam
    {
        public string TypeTeam()
        {
            return "Green";
        }
    }
    class Blue : ITeam
    {
        public string TypeTeam()
        {
            return "Blue";
        }
    }
    class Yellow : ITeam
    {
        public string TypeTeam()
        {
            return "Yellow";
        }
    }
}
