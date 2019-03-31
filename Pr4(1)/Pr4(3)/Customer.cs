using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr4_3_
{
    abstract class Customer//Element
    {
        public string date;
        public abstract string Accept(Director dir);
    }
    class Customer1 : Customer//ElementA
    {
        public Customer1(string date)
        {
            this.date = date;
        }
        public override string Accept(Director dir)//оголошення наради
        {
            return dir.VisitCustomer(this);
        }
    }
    class Customer2 : Customer//ElementB
    {
        public Customer2(string date)
        {
            this.date = date;
        }
        public override string Accept(Director dir)//оголошення наради
        {
           return dir.VisitCustomer(this);
        }
    }
    class Customer3 : Customer
    {
        public Customer3(string date)
        {
            this.date = date;
        }
        public override string Accept(Director dir)//оголошення наради
        {
            return dir.VisitCustomer(this);
        }
    }
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
        public string Accept(Director dir)
        {
            foreach (Customer customer in customers)
            {
                return customer.Accept(dir);
            }
            return "";
        }
    }
}
