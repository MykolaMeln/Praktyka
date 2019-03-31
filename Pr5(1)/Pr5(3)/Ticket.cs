using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr5_3_
{
    interface IClass//IStrategy
    {
        int Vartist(bool Vikno, bool Return);
    }

    class Ekonom : IClass//ConcreteStrategy1
    {
        public int Cina = 100;
        public int Vartist(bool Vikno, bool Return)
        {
            if (Vikno == true)
            {
                Cina += 10;
            }
            if (Return == true)
            {
                Cina += 50;
            }
            return Cina;
        }
    }

    class Business : IClass//ConcreteStrategy2
    {
        public int Cina = 150; 
        public int Vartist(bool Vikno, bool Return)
        {
            if (Vikno == true)
            {
                Cina += 10;
            }
            if (Return == true)
            {
                Cina += 50;
            }
            return Cina;
        }
    }

    class First : IClass//ConcreteStrategy3
    {
        public int Cina = 200;
        public int Vartist(bool Vikno, bool Return)
        {
            if(Vikno == true)
            {
                Cina += 10;
            }
            if(Return == true)
            {
                Cina += 5;
            }
            return Cina;
        }
    }

    class Hot : IClass//ConcreteStrategy4
    {
        public int Cina = 50;
        public int Vartist(bool Vikno, bool Return)
        {
            if(Vikno == true)
            {
                Cina += 10;
            }
            return Cina;
        }
    }
    class Ticket//Context
    { 
        public bool Vikno;
        public bool Return;
        public IClass clas { get; set; }
        public Ticket(IClass clas, bool vikno, bool ret)
        {
            Return = ret;
            Vikno = vikno;
            this.clas = clas;
        }
        public int Vartist()
        {
            return clas.Vartist(Vikno, Return);
        }
    }

}
