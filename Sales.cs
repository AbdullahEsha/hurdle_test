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
            Console.WriteLine("Sales:");
            decimal total = 0;
            foreach (Thing order in orders)
            {
                if (order is Batch)
                {
                    if (total > 0)
                    {
                        Console.WriteLine($"Total: {total:C2}");
                        total = 0;
                    }
                    order.Print();
                }
                else
                {
                    total += order.Total();
                    order.Print();
                }
            }
            if (total > 0)
            {
                Console.WriteLine($"Total: {total:C2}");
            }

            Console
                .WriteLine($"Sales total: {
                    orders.Sum(order => order.Total()):C2}");
        }
    }
}
