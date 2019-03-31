using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr4_3_
{
    abstract class Director //Visitor
    {
        public abstract string VisitCustomer(Customer1 customer1);
        public abstract string VisitCustomer(Customer2 customer2);
        public abstract string VisitCustomer(Customer3 customer3);
    }
    class Director1 : Director//ConcreteVisitor1
    {
        public override string VisitCustomer(Customer1 customer1)
        {
            //  WriteLine("Клiєнт " + customer3.name + " вiдвiдав " + GetType().Name);
            return customer1.date + " " + GetType().Name;
        }

        public override string VisitCustomer(Customer2 customer2)
        {
            //   WriteLine("Клiєнт " + customer2.name + " може заплатити лише 50грн. " + GetType().Name);
            return customer2.date + " " + GetType().Name;
        }

        public override string VisitCustomer(Customer3 customer3)
        {
            //  WriteLine("Клiєнт " + customer2.name + " може заплатити 100грн. " + GetType().Name);
            return customer3.date + " " + GetType().Name;
        }
    }
    class Director2 : Director//ConcreteVisitor2
    {
        public override string VisitCustomer(Customer1 customer1)
        {
            //   WriteLine("Клiєнт " + tcustomer.name + " вiдвiдав " + GetType().Name);
            return customer1.date + " " + GetType().Name;
        }

        public override string VisitCustomer(Customer2 customer2)
        {
            //  WriteLine("Клiєнт " + customer1.name + " не поїхав на " + GetType().Name + "." + " Вiн не має грошей.");
            return customer2.date + " " + GetType().Name;
        }

        public override string VisitCustomer(Customer3 customer3)
        {
            //    WriteLine("Клiєнт " + customer2.name + " може заплатити 200грн. " + GetType().Name);
            return customer3.date + " " + GetType().Name;
        }
    }
}
