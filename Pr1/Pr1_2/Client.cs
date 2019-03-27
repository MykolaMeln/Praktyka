using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Pr1_2
{
    class Client
    {
        private IAllPhonesFactory factory;
        private string firmName;
        private IPhone phone;
        private ISmartphone smartphone;
        public Client(string firmName) { this.firmName = firmName; }
        public void ShowPhones()
        {
            switch (firmName)
            {
                case "Samsung":
                    factory = new SamsungFactory();
                    break;
                case "LG":
                    factory = new LGFactory();
                    break;
            }
            WriteLine(firmName + ":\nSmart Phone: " +
            factory.getSmartphone().Name() + "\nPhone: " + factory.getPhone().Name());
        }
    }
}

