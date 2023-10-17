using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOOP
{
    internal class Cow : Reptile
    {
        public Cow(string name, int age, string habitat, double weight, string favoriteFood, string gender, bool isSpotted, bool isMulticolored, bool isPredator)
            : base(name, age, habitat, weight, favoriteFood, gender, 4, 70, isSpotted, isMulticolored, isPredator)
        {
        }

        public void TouchGrass()
        {
            Console.WriteLine($"{Name} is so happy to touch grass.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} lets out a big Moo.");
        }
    }
}