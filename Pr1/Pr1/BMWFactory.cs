using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
        public interface ICarAbstractFactory
        {
            ICar HatchBack();
            ICar Sedan();
            ICar Universal();
        }
        class BMWX5 : BMW
        {
            public BMWX5() { name = "X5"; speed = 340; type = "HatchBack"; }
        }
        class BMWE46 : BMW
        {
            public BMWE46() { name = "E46"; speed = 240; type = "Sedan"; }
        }
        class BMWE39 : BMW
        {
            public BMWE39() { name = "E39"; speed = 230; type = "Universal"; }
        }
        public class BMWFactory : ICarAbstractFactory
        {
            public ICar HatchBack()
            {
                return new BMWX5();
            }
            public ICar Sedan()
            {
                return new BMWE46();
            }
            public ICar Universal()
            {
                return new BMWE39();
            }
        }
        
}
