using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Pr5_2_
{
    interface IPrint//IStrategy
    {
        void Algorithm();
    }

    class Laser : IPrint//ConcreteStrategy1
    {
        public void Algorithm()
        {
            WriteLine("Printed on a Laser printer.");
        }
    }

    class Matrix : IPrint//ConcreteStrategy2
    {
        public void Algorithm()
        {
            WriteLine("Printed on a Matrix printer.");
        }
    }

    class Inkjet : IPrint//ConcreteStrategy3
    {
        public void Algorithm()
        {
            WriteLine("Printed on a Inkjet printer.");
        }
    }

    class LED : IPrint//ConcreteStrategy4
    {
        public void Algorithm()
        {
            WriteLine("Printed on a LED printer.");
        }
    }
    class Printer//Context
    {
        public IPrint print { private get; set; }
        public Printer(IPrint print)
        {
            this.print = print;
        }
        public void Print()
        {
            print.Algorithm();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Printer pr = new Printer(new Matrix());//Context
            WriteLine("Matrix: ");
            pr.Print();
            WriteLine();

            WriteLine("Laser:");
            pr.print = new Laser();
            pr.Print();
            WriteLine();

            WriteLine("Inkjet: ");
            pr.print = new Inkjet();
            pr.Print();
            WriteLine();

            WriteLine("LED: ");
            pr.print = new LED();
            pr.Print();

            ReadKey();
        }
    }
}