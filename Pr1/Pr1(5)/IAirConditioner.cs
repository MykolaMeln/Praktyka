using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1_5_
{
    public interface IAirConditioner
    {
        string Operate();
    }
    public class Cooling : IAirConditioner
    {
        private double _temperature;

        public Cooling(double temperature)
        {
            _temperature = temperature;
        }

        public string Operate()
        {           
            return "Cooling the room to the required temperature of "+_temperature+" degrees\n";
        }
    }
    public class Warming : IAirConditioner
    {
        private readonly double _temperature;

        public Warming(double temperature)
        {
            _temperature = temperature;
        }

        public string Operate()
        {
            return "Warming the room to the required temperature of "+_temperature +" degrees\n";
        }
    }

}
