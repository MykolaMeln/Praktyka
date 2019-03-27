using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1_2
{
    public interface IAllPhonesFactory
    {
        IPhone getPhone();
        ISmartphone getSmartphone();
    }
    public class SamsungFactory : IAllPhonesFactory
    {
        public IPhone getPhone()
        {
            return new SamsungPhone();
        }
        public ISmartphone getSmartphone()
        {
            return new SamsungSmartphone();
        }

    }
    public class LGFactory : IAllPhonesFactory
    {
        public IPhone getPhone()
        {
            return new LGPhone();
        }
        public ISmartphone getSmartphone()
        {
            return new LGSmartphone();
        }
    }
}
