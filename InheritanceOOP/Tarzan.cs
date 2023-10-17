using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOOP
{
    internal class Tarzan : Mammal
    {
        public Tarzan(string name, int age, string habitat, double weight, string favoriteFood, string gender, bool isSpotted, bool isMulticolored, bool isPredator)
            : base(name, age, habitat, weight, favoriteFood, gender, true, false, true) // Example values for isSpotted, isMulticolored, isPredator
        {
        }

        public void Swing()
        {
            Console.WriteLine($"{Name} is swinging through the jungle like Tarzan!");
        }
    }
}