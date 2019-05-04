using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр6
{
    abstract class Vartist
    {
        public abstract void setVart(double v);
        public abstract double getVart();
        public abstract string Info();
    }
    class Posylka : Vartist
    {
        public string misto1;
        public string misto2;
        public double beginvart;
        public double vart = 0;
        public Posylka(string misto1, string misto2, double beginvart)
        {
            this.misto1 = misto1;
            this.misto2 = misto2;
            this.beginvart = beginvart;
        }
        public override void setVart(double v)
        {
            vart += v;
        }
        public override double getVart()
        {
            return vart;
        }
        public override string Info()
        {
            return misto1 + " " + misto2 + " " + beginvart;
        }

    }

    abstract class Decorator : Vartist
    {
        protected Vartist component;

        public void SetComponent(Vartist component)
        {
            this.component = component;
        }
        public override void setVart(double v)
        {
            component.setVart(v);
        }
        public override double getVart()
        {
            return component.getVart();
        }
    }
    
    class Strahovka : Decorator
    {
        bool yes = false;
        public Strahovka(bool str) { yes = str; }
        public override double getVart()
        {
            double Vart = 0;
            if (yes == true)
            {
                component.setVart(100);
                Vart = 100;
            }
            if(yes == false)
            {
                Vart = 0;
            }
            return Vart;
        }
        public override string Info()
        {
            return yes.ToString();
        }
    }
    class ClassVidp : Decorator
    {
        string classvidp;
        public ClassVidp(string clas) { classvidp = clas; }
        public override double getVart()
        {
            double Vart = 0;
            if (classvidp == "Перший")
            {
                setVart(200);
                Vart = 200;
            }
            if (classvidp == "Бізнес")
            {
                setVart(100);
                Vart = 100;
            }
            if (classvidp == "Експрес")
            {
                setVart(150);
                Vart = 150;
            }
            if(classvidp == "")
            {
                Vart = 0; 
            }
            return Vart;
        }
        public override void setVart(double v)
        {
            base.setVart(v);
        }
        public override string Info()
        {
            return classvidp;
        }

    }
}
