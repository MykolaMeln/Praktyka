using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Pr3_2_
{
    interface IObservable
    {
        void attach(Observer o);
        void setCount(int val);
        void notifyAllObserver();
    }
    public abstract class Observer
    {
        protected Office sub;
        public abstract void update();
    }
    public class Office : IObservable
    {
        public List<Observer> views = new List<Observer>();
        public int count;

        public void attach(Observer obs)
        {
            views.Add(obs);
        }
        public void setCount(int val)
        {
            count = val;
            notifyAllObserver();//сповіщення
        }
        public int getCount()
        {
            return count;
        }
        public void notifyAllObserver()
        {
            foreach (Observer obs in views)
            {
                obs.update();
            }
        }
    }
    public class Station : Observer
    {
        public Station(Office sub)
        {
            this.sub = sub;
            this.sub.attach(this);
        }
        public override void update()
        {
            WriteLine("Station are notify: " + this.sub.getCount());
        }
    }
    public class Program
    {

        static void Main(string[] args)
        {
            Office sub = new Office();
          
            new Station(sub);

            WriteLine("You've notify: 5 station");

            sub.setCount(5);

            ReadKey();
        }
    }
}
