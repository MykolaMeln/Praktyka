using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Collections;

namespace Pr3_1_
{
    public interface IObserable
    { 
        void addBuyer(Buyer buyer);
        void findHighestBidder();
    }

    public class Auctionner : IObserable//Subject
    {
        private ArrayList buyers;

        public Auctionner()
        {
            buyers = new ArrayList();
        }
        public void addBuyer(Buyer buyer)
        {
            buyers.Add(buyer);
            WriteLine(buyer.name + " was added to the buyers list.");
        }
        public void findHighestBidder()
        {
            int max = 0;
            Buyer winner = null;
            foreach (Buyer b in buyers)
            {
                if (b.price > max)
                {
                    max = b.price;
                    winner = b;
                }
            }
            WriteLine("The auction winner is " + winner.name +". He paid " + winner.price + "$ for the item.");
        }
    }
    
public abstract class Buyer//Observer
{
    protected IObserable obser;
    public string name;
    public int price;

    public Buyer(IObserable obs, String name)
    {
        obser = obs;
        this.name = name;
    }
    public abstract void bid(int price);
    public abstract void cancelTheBid();
}

    public class AuctionBuyer : Buyer
    {
        public AuctionBuyer(IObserable obs, string name):base(obs, name)
        {
            obser = obs;
            this.name = name;
        }
        public override void bid(int price)
        {
            this.price = price;
        }
        public override void cancelTheBid()
        {
            this.price = -1;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {

            Auctionner med = new Auctionner();
            Buyer b1 = new AuctionBuyer(med, "John Smith");
            Buyer b2 = new AuctionBuyer(med, "Elina Smilova");
            Buyer b3 = new AuctionBuyer(med, "Alex Loky");

            med.addBuyer(b1);
            med.addBuyer(b2);
            med.addBuyer(b3);

            b1.bid(1800);
            b2.bid(2000);
            b3.bid(780);
            WriteLine("---------------------------------");
            med.findHighestBidder();

            b2.cancelTheBid();
            WriteLine(b2.name + " Has canceled his bid!, ");
            med.findHighestBidder();
            ReadKey();
        }
    }
}
