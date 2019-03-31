using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Pr4_2_
{
    abstract class Taxi//Visitor
    {
        public abstract void VisitCustomer(TaxiCustomer customer);
        public abstract void VisitCustomer(Customer1 customer1);
        public abstract void VisitCustomer(Customer2 customer2);
    }
    class Taxi1 : Taxi//ConcreteVisitor1
    {
        public override void VisitCustomer(TaxiCustomer tcustomer)
        {
            WriteLine("Клiєнт "+tcustomer.name + " вiдвiдав " + GetType().Name);
        }

        public override void VisitCustomer(Customer1 customer1)
        {
            WriteLine("Клiєнт " + customer1.name + " може заплатити лише 50грн. " + GetType().Name);
        }

        public override void VisitCustomer(Customer2 customer2)
        {
            WriteLine("Клiєнт " + customer2.name + " може заплатити 100грн. " + GetType().Name);
        }
    }
    class Taxi2 : Taxi//ConcreteVisitor2
    {
        public override void VisitCustomer(TaxiCustomer tcustomer)
        {
            WriteLine("Клiєнт " + tcustomer.name + " вiдвiдав " + GetType().Name);
        }

        public override void VisitCustomer(Customer1 customer1)
        {
            WriteLine("Клiєнт " + customer1.name + " не поїхав на " + GetType().Name + "." + " Вiн не має грошей.");
        }

        public override void VisitCustomer(Customer2 customer2)
        {
            WriteLine("Клiєнт " + customer2.name + " може заплатити 200грн. " + GetType().Name);
        }
    }

}
