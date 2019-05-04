using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр6_2_
{
    abstract class Travel
    {
        public abstract void setVart(double v);
        public abstract double getVart();
        public abstract string Info();
    }
    class Ticket : Travel
    {
        public string country;
        public double vart = 0;
        public Ticket(string country)
        {
            this.country = country;
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
            return country;
        }
    }
    abstract class Decorator : Travel
    {
        protected Travel component;

        public void SetComponent(Travel component)
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

    class Move : Decorator
    {
        string sposib;
        public Move(string sposib) { this.sposib = sposib; }
        public override double getVart()
        {
            double Vart = 0;
            if (sposib == "Автобус")
            {
                component.setVart(50);
                Vart = 50;
            }
            if (sposib == "Літак")
            {
                component.setVart(150);
                Vart = 150;
            }
            if (sposib == "Поїзд")
            {
                component.setVart(100);
                Vart = 100;
            }
            return Vart;
        }
        public override string Info()
        {
            return sposib;
        }

    }
    class Dni : Decorator
    {
        int dni;
        public Dni(string dni) { this.dni = Convert.ToInt32(dni); }
        public override double getVart()
        {
            double Vart = 0;
            if (dni == 7)
            {
                component.setVart(70);
                Vart = 70;
            }
            if (dni == 14)
            {
                component.setVart(140);
                Vart = 140;
            }
            if (dni == 20)
            {
                component.setVart(200);
                Vart = 200;
            }
            return Vart;
        }
        public override string Info()
        {
            return dni.ToString();
        }
    }
    class Hotel : Decorator
    {
        string nomer;
        string vyd;
        public Hotel(string nomer, string vyd) { this.nomer = nomer; this.vyd = vyd; }
        public override double getVart()
        {
            double Vart = 0;
            if (nomer == "Економ")
            {
                component.setVart(300);
                Vart = 300;
            }
            if (nomer == "Люкс")
            {
                component.setVart(500);
                Vart = 500;
            }
            if (nomer == "Президентський")
            {
                component.setVart(1000);
                Vart = 1000;
            }
            if(vyd == "Море")
            {
                component.setVart(50);
                Vart = Vart + 50;
            }
            if(vyd == "Місто")
            {
                component.setVart(20);
                Vart = Vart + 20;
            }
            if(vyd == "Пальми")
            {
                component.setVart(30);
                Vart = Vart + 30;
            }
            return Vart;
        }
        public override string Info()
        {
            return nomer;
        }
    }
    class Ekskursii : Decorator
    {
        bool yes = false;
        public Ekskursii(bool str) { yes = str; }
        public override double getVart()
        {
            double Vart = 0;
            if (yes == true)
            {
                component.setVart(200);
                Vart = 200;
            }
            if (yes == false)
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
}
