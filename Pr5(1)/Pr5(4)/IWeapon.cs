using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr5_4_
{
    interface IWeapon
    {
        string TypeWeapon();
    }

    class Sword : IWeapon
    {
        public string TypeWeapon()
        {
            return "Sword";
        }
    }
    class Bow : IWeapon
    {
        public string TypeWeapon()
        {
            return "Bow with arrows";
        }
    }
    class Arbalet : IWeapon
    {
        public string TypeWeapon()
        {
            return "Arbalet";
        }
    }

}
