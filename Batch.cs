using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurdleTask
{
    public class Batch : Thing
    {
        public Batch(string number, string name) :
            base(number, name)
        {
        }

        public override decimal Total()
        {
            return 0;
        }

        public override void Print()
        {
            Console.WriteLine($"Batch sale: #{Number}, {Name}");
        }
    }
}
