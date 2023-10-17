using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InheritanceOOP
{
    internal class Flower : Plant
    {
        public Flower(string name, int age, string habitat, double weight, string favoriteFood, bool isMulticolored)
            : base(name, age, habitat, weight, favoriteFood, isMulticolored)
        {
        }

        public void Bloom()
        {
            Console.WriteLine($"{Name} is blooming.");
        }

        public override void Grow()
        {
            Console.WriteLine($"{Name} growing is my superpower.");
        }
        public void Speak()
        {
            Console.WriteLine($"{Name} says absolutely nothing. It's a flower. What did you expect?!");
        }
    }
}