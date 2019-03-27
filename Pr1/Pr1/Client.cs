using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Pr1
{
    class Client
    {
        public ICarAbstractFactory factory;
        public string type;
        public Client(ICarAbstractFactory factory, string type)
        {
            this.factory = factory;
            this.type = type;
        }
        public void Display()
        { 
            ICar car = null;
            if (type == "HatchBack")
            {
                car = factory.HatchBack();
            }
            if (type == "Sedan")
            {
                car = factory.Sedan();
            }
            if (type == "Universal")
            {
                car = factory.Universal();
            }
            WriteLine("Car: " + car.Name() + " " + car.Type() + " " + car.Speed());

        }
    }
}
