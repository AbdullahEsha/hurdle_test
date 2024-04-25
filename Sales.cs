using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurdleTask
{
    public class Sales
    {
        private List<Thing> orders = new List<Thing>();

        public Sales()
        {
            orders = new List<Thing>();
        }

        public void Add(Thing order)
        {
            orders.Add (order);
        }

        public void PrintOrders()
        {
            foreach (Thing order in orders)
            {
                order.Print();
            }

            decimal total = 0;

            foreach (Thing order in orders)
            {
                total += order.Total();
            }

            Console.WriteLine($"Total: {total:C2}");
        }
    }
}
