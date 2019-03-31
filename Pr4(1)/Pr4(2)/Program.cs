using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Pr4_2_
{
   
    class CustomerStructure
    {
        private List<Customer> customers = new List<Customer>();

        public void Add(Customer customer)
        {
            customers.Add(customer);
        }
        public void Remove(Customer customer)
        {
            customers.Remove(customer);
        }
        public void Accept(Taxi taxi)
        {
            foreach (Customer customer in customers)
            {
                customer.Accept(taxi);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CustomerStructure cs = new CustomerStructure();

            cs.Add(new TaxiCustomer("Джек"));
            cs.Add(new TaxiCustomer("Денис"));
            cs.Add(new TaxiCustomer("Джон"));
            cs.Add(new Customer1("Сем"));
            cs.Add(new Customer2("Саша"));

            Taxi t1 = new Taxi1();
            Taxi t2 = new Taxi2();

            cs.Accept(t1);
            WriteLine();
            cs.Accept(t2);

            ReadKey();
        }
    }
}
