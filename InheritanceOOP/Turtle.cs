using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOOP
{
    internal class Turtle : Reptile
    {
        public Turtle(string name, int age, string habitat, double weight, string favoriteFood, string gender, bool isSpotted, bool isMulticolored, bool isPredator)
            : base(name, age, habitat, weight, favoriteFood, gender, 4, 70, isSpotted, isMulticolored, isPredator)
        {
        }

        public void EatQuito()
        {
            Console.WriteLine($"{Name} sticks out it's tongue trying to eat quito");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} makes munching sounds as it eats pizza down in the sewers.");
        }
    }
}
