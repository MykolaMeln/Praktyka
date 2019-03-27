using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Pr2_3
{
    public class OrderedItems
    {
        List<Item> items = new List<Item>();
        public void addItems(Item item)
        {

            items.Add(item);
        }
        public float getCost()
        {
            float cost = 0.0f;
            foreach (Item item in items)
            {
                cost += item.price();
            }
            return cost;
        }
        public string showItems()
        {
            string res = "";
            foreach (Item item in items)
            {
                res += item.name() + " " + item.price() + " " + item.size()+"/n";
            }
            return res;
        }
    }
}
