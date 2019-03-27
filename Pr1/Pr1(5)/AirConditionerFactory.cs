using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1_5_
{
    public abstract class AirConditionerFactory
    {
        public abstract IAirConditioner Create(double temperature);
    }
    public class CoolingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature)
        {
           return new Cooling(temperature);
        }
    }
    public class WarmingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature)
        {
            return new Warming(temperature);
        }
    }
}
