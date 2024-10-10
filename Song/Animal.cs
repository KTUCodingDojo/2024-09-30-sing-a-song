using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song
{
    public class Animal
    {
        public string Name { get; }
        public string UniqueLine { get; }
        public Animal(string name, string uniqueLine)
        {
            Name = name;
            UniqueLine = uniqueLine;
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
