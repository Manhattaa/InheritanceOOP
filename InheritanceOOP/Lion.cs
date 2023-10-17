using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOOP
{
    internal class Lion : Animal
    {
        public Lion(string name, int age, string habitat, double weight, string favoriteFood, string gender, bool isSpotted, bool isMulticolored, bool isPredator)
            : base(name, age, habitat, weight, favoriteFood, gender, isSpotted, isMulticolored, isPredator)
        {
        }

        public void Roar()
        {
            Console.WriteLine($"{Name} is roaring.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} roars like the lion it is.");
        }
    }
}