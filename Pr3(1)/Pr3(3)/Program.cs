using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Pr3_3_
{
    interface IObservable
    {
        void addobserver(IObserver o);
        void setChyslo(string val);
        string getChyslo();
        void NotifyObservers();
    }
    public interface IObserver
    {
        void update();
    }
    public class Chyslo : IObservable
    {
        public List<IObserver> observers = new List<IObserver>();
            
        public string chyslo;

        public void addobserver(IObserver obs)
        {
            observers.Add(obs);
        }
        public void setChyslo(string val)
        {
            chyslo = val;
        }
        public string getChyslo()
        {
            return chyslo;
        }
        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            { observer.update(); }
        }

    }
    public class Dvijkova : IObserver
    {
        string chyslo;
        public  Dvijkova(string chyslo)
        {
            this.chyslo = chyslo;
        }
        public void update()
        {
            int ch;
            ch = Convert.ToInt32(chyslo);
            WriteLine("Число в 2-й: " + Convert.ToString(ch, 2));
        }
    }
    public class Visimkova : IObserver
    {
        string chyslo;
        public Visimkova(string chyslo)
        {
            this.chyslo = chyslo;
        }
        public void update()
        {
            int ch;
            ch = Convert.ToInt32(chyslo);
            WriteLine("Число в 8-й: " + Convert.ToString(ch, 8));
        }
    }
    public class Desyatkova : IObserver
    {
        string chyslo;
        public Desyatkova(string chyslo)
        {
            this.chyslo = chyslo;
        }
        public void update()
        {
            int ch;
            ch = Convert.ToInt32(chyslo);
            WriteLine("Число в 10-й: " + Convert.ToString(ch, 10));
        }
    }
    public class Shistn : IObserver
    {
        string chyslo;
        public Shistn(string chyslo)
        {
            this.chyslo = chyslo;
        }
        public  void update()
        {
            int ch;
            ch= Convert.ToInt32(chyslo);
            WriteLine("Число в 16-й: " + Convert.ToString(ch, 16));
        }
    }
    public class Program
    {

        static void Main(string[] args)
        {

            Chyslo sub = new Chyslo();
            Write("Число: ");
            string a = ReadLine();
            sub.addobserver(new Dvijkova(a));
            sub.addobserver(new Visimkova(a));
            sub.addobserver(new Desyatkova(a));
            sub.addobserver(new Shistn(a));

            sub.NotifyObservers();

            ReadKey();
        }
    }
}
