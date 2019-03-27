using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Pr1
{
    public interface ICar
    {
        string Name();
        int Speed();
        string Type();
    }
    abstract class BMW : ICar
    {
        protected string name;
        protected int speed;
        protected string type;

        public string Name() { return name; }
        public int Speed() { return speed; }
        public string Type() { return type; }
    }
    abstract class Ford : ICar
    {
        protected string name;
        protected int speed;
        protected string type;

        public string Name() { return name; }
        public int Speed() { return speed; }
        public string Type() { return type; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Client client = null;
            string type;
            Write("Type: ");
            type = ReadLine();
            client = new Client(new BMWFactory(), type);
            client.Display();

            Write("Type: ");
            type = ReadLine();
            client = new Client(new FORDFactory(), type);
            client.Display();
            ReadKey();
        }
    }
}
