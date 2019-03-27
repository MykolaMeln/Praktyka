using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DomZavd
{
    abstract class Card//Component
    {
        public string Number;
        public abstract void Operation();
    }
    class Passport : Card//ConcreteComponent
    {
        public string Seria;
         public Passport() { Number = "186852"; Seria = "КН"; }

        public override void Operation()
        {
            WriteLine("Passport: " + Seria + " " + Number);
        }
    }
    abstract class Universal_Card : Card//Decorator
    {
        protected Card component;

        public void SetComponent(Card component)
        {
            this.component = component;
        }
        public override void Operation()
        {
            if (component != null)
                component.Operation();
        }
    }
    class Credit_Card : Universal_Card//ConcreteDecoratorA
    {
        public string Date;
        public Credit_Card(Card CD) { Date = "12/03/2019"; Number = "5168 9435 2312 4356"; }
        public override void Operation()
        {
            WriteLine("+Credit_Card " + Date + " " + Number);
        }
    }
    class Identity_Code : Universal_Card//ConcreteDecoratorB
    {
        public Identity_Code(Card CD ) { Number = "324516784536361"; } 
        public override void Operation()
        {
            WriteLine("+Identity_Code " + Number);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Card UC = new Passport();
            UC.Operation();
            UC = new Credit_Card(UC);
            UC.Operation();
            UC = new Identity_Code(UC);
            UC.Operation();

            ReadKey();
        }
    }
}
