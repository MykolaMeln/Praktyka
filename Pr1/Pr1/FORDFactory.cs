using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    class FordFocus : Ford
    {
        public FordFocus() { name = "Focus"; speed = 280; type = "HatchBack"; }
    }
    class FordMustang : Ford
    {
        public FordMustang() { name = "Mustang"; speed = 360; type = "Sedan"; }
    }
    class FordTurnier : Ford
    {
        public FordTurnier() { name = "Turnier"; speed = 250; type = "Universal"; }
    }
    class FORDFactory : ICarAbstractFactory
    {
        public ICar HatchBack()
        {
            return new FordFocus();
        }
        public ICar Sedan()
        {
            return new FordMustang();
        }
        public ICar Universal()
        {
            return new FordTurnier();
        }
    }
}
