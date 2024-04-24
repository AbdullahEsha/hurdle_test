using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurdleTask
{
    public class Transaction : Thing
    {
        public decimal Price { get; set; }

        public Transaction(string number, string name, decimal price) :
            base(number, name)
        {
            Price = price;
        }

        public override decimal Total()
        {
            return Price;
        }

        public override void Print()
        {
            Console.WriteLine($"#{Number}, {Name}, {Price:C2}");
        }
    }
}
