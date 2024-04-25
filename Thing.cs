using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurdleTask
{
    public abstract class Thing
    {
        public string Number { get; set; }

        public string Name { get; set; }

        public decimal Item { get; set; }

        public Thing(string number, string name, decimal item = 0)
        {
            Number = number;
            Name = name;
            Item = item;
        }

        public abstract decimal Total();

        public abstract void Print();
    }
}
