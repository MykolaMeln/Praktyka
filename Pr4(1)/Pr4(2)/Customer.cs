using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr4_2_
{
    abstract class Customer//Element
    {
        public string name;
        public abstract void Accept(Taxi taxi);
    }
    class Customer1 : Customer//ElementA
    {
        public Customer1(string Name)
        {
            name = Name;
        }
        public override void Accept(Taxi taxi)//поїздка на таксі
        {
            taxi.VisitCustomer(this);
        }
    }
    class Customer2 : Customer//ElementB
    {
        public Customer2(string Name)
        {
            name = Name;
        }
        public override void Accept(Taxi taxi)//поїздка на таксі
        {
            taxi.VisitCustomer(this);
        }
    }
    class TaxiCustomer : Customer
    {
        public TaxiCustomer(string Name)
        {
            name = Name;
        }
        public override void Accept(Taxi taxi)//поїздка на таксі
        {
            taxi.VisitCustomer(this);
        }
    }
}
