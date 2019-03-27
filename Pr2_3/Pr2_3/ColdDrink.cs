using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2_3
{
    public abstract class ColdDrink : Item
    {
        public abstract float price();
        public abstract string name();
        public abstract string size();
    }
    public abstract class Pepsi : ColdDrink
    {
        public override abstract string name();
        public override abstract string size();
        public override abstract float price();
    }
    public abstract class Coke : ColdDrink
    {
        public override abstract string name();
        public override abstract string size();
        public override abstract float price();
    }
    public class SmallPepsi : Pepsi
    {
        public override string name()
        {
            return "300 ml Pepsi";
        }
        public override float price()
        {
            return 25.0f;
        }
        public override string size()
        {
            return "Small Size";
        }
    }
    public class MediumPepsi : Pepsi
    {
        public override string name()
        {
            return "500 ml Pepsi";
        }
        public override float price()
        {
            return 35.0f;
        }
        public override string size()
        {
            return "Small Size";
        }
    }
    public class LargePepsi : Pepsi
    {
        public override string name()
        {
            return "750 ml Pepsi";
        }
        public override float price()
        {
            return 50.0f;
        }
        public override string size()
        {
            return "Large Size";
        }
    }
    public class SmallCoke : Coke
    {
        public override string name()
        {
            return "300 ml Pepsi";
        }
        public override float price()
        {
            return 25.0f;
        }
        public override string size()
        {
            return "Small Size";
        }
    }
    public class MediumCoke : Coke
    {
        public override string name()
        {
            return "500 ml Pepsi";
        }
        public override float price()
        {
            return 35.0f;
        }
        public override string size()
        {
            return "Small Size";
        }
    }
    public class LargeCoke : Coke
    {
        public override string name()
        {
            return "750 ml Pepsi";
        }
        public override float price()
        {
            return 50.0f;
        }
        public override string size()
        {
            return "Large Size";
        }
    }

}
