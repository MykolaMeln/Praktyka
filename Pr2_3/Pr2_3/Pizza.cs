using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2_3
{
    public interface Item
    {
        string name();
        string size();
        float price();
    }
    public abstract class Pizza : Item
    {
        public abstract float price();
        public abstract string name();
        public abstract string size();
    }
    public abstract class VegPizza : Pizza
    {
        public override abstract float price();
        public override abstract string name();
        public override abstract string size();
    }
    public abstract class NonVegPizza : Pizza
    {
        public override abstract float price();
        public override abstract string name();
        public override abstract string size();
    }
    public class SmallCheezePizza : VegPizza
    {
        public override float price()
        {
            return 170.0f;
        }
        public override string name()
        {
            return "Cheeze Pizza";
        }
        public override string size()
        {
            return "Small size";
        }
    }
    public class MediumCheezePizza : VegPizza
    {
        public override float price()
        {
            return 220.0f;
        }
        public override string name()
        {
            return "Cheeze Pizza";
        }
        public override string size()
        {
            return "Medium Size";
        }
    }
    public class LargeCheezePizza : VegPizza
    {
        public override float price()
        {
            return 260.0f;
        }
        public override string name()
        {
            return "Cheeze Pizza";
        }
        public override string size()
        {
            return "Large Size";
        }
    }
    public class ExtraLargeCheezePizza : VegPizza
    {
        public override float price()
        {
            return 300.0f;
        }
        public override string name()
        {
            return "Cheeze Pizza";
        }
        public override string size()
        {
            return "Extra-Large Size";
        }
    }
    public class SmallOnionPizza : VegPizza
    {
        public override float price()
        {
            return 120.0f;
        }
        public override string name()
        {
            return "Onion Pizza";
        }
        public override string size()
        {
            return "Small size";
        }
    }
    public class MediumOnionPizza : VegPizza
    {
        public override float price()
        {
            return 150.0f;
        }
        public override string name()
        {
            return "Onion Pizza";
        }
        public override string size()
        {
            return "Medium Size";
        }
    }
    public class LargeOnionPizza : VegPizza
    {
        public override float price()
        {
            return 180.0f;
        }
        public override string name()
        {
            return "Onion Pizza";
        }
        public override string size()
        {
            return "Large Size";
        }
    }
    public class ExtraLargeOnionPizza : VegPizza
    {
        public override float price()
        {
            return 200.0f;
        }
        public override string name()
        {
            return "Onion Pizza";
        }
        public override string size()
        {
            return "Extra-Large Size";
        }
    }
    public class SmallMasalaPizza : VegPizza
    {
        public override float price()
        {
            return 100.0f;
        }
        public override string name()
        {
            return "Masala Pizza";
        }
        public override string size()
        {
            return "Small size";
        }
    }
    public class MediumMasalaPizza : VegPizza
    {
        public override float price()
        {
            return 120.0f;
        }
        public override string name()
        {
            return "Masala Pizza";
        }
        public override string size()
        {
            return "Medium Size";
        }
    }
    public class LargeMasalaPizza : VegPizza
    {
        public override float price()
        {
            return 150.0f;
        }
        public override string name()
        {
            return "Masala Pizza";
        }
        public override string size()
        {
            return "Large Size";
        }
    }
    public class ExtraLargeMasalaPizza : VegPizza
    {
        public override float price()
        {
            return 180.0f;
        }
        public override string name()
        {
            return "Masala Pizza";
        }
        public override string size()
        {
            return "Extra-Large Size";
        }
    }
    public class SmallNonVegPizza : NonVegPizza
    {
        public override float price()
        {
            return 180.0f;
        }
        public override string name()
        {
            return "Non-Veg Pizza";
        }
        public override string size()
        {
            return "Small size";
        }
    }
    public class MediumNonVegPizza : NonVegPizza
    {
        public override float price()
        {
            return 200.0f;
        }
        public override string name()
        {
            return "Non-Veg Pizza";
        }
        public override string size()
        {
            return "Medium Size";
        }
    }
    public class LargeNonVegPizza : NonVegPizza
    {
        public override float price()
        {
            return 220.0f;
        }
        public override string name()
        {
            return "Non-Veg Pizza";
        }
        public override string size()
        {
            return "Large Size";
        }
    }
    public class ExtraLargeNonVegPizza : NonVegPizza
    {
        public override float price()
        {
            return 250.0f;
        }
        public override string name()
        {
            return "Non-Veg Pizza";
        }
        public override string size()
        {
            return "Extra-Large Size";
        }
    }












}
