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

        public Thing(string number, string name)
        {
            Number = number;
            Name = name;
        }

        public abstract decimal Total();

        public abstract void Print();
    }
}
