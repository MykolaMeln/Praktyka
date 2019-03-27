using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Pr1_2
{
    public interface IPhone
    {
        string Name();
    }
    public interface ISmartphone
    {
        string Name();
    }
    class LGPhone : IPhone
    {
        public string Name()
        {
            return "This is LGPhone";
        }
    }
    class LGSmartphone : ISmartphone
    {
        public string Name()
        {
            return "This is LGSmartphone";
        }
    }
    class SamsungPhone : IPhone
    {
        public string Name()
        {
            return "This is SamsungPhone";
        }
    }
    class SamsungSmartphone : ISmartphone
    {
        public string Name()
        {
            return "This is SamsungSmartphone";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Client client;
            WriteLine("FirmName(Samsung or LG): ");
            string firmName = ReadLine();
            client = new Client(firmName);
            client.ShowPhones();
           
            ReadKey();
        }
    }
}
