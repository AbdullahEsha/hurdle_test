using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HurdleTask
{
    public class Batch : Thing
    {
        private List<Thing> items;

        public Batch(string number, string name) :
            base(number, name)
        {
            items = new List<Thing>();
        }

        public override decimal Total()
        {
            return 0;
        }

        public override void Print()
        {
            Console.WriteLine($"Batch: {Name}");
        }
    }
}
