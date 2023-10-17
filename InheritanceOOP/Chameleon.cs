using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOOP
{
    internal class Chameleon : Reptile
    {
        public Chameleon(string name, int age, string habitat, double weight, string favoriteFood, string gender, bool isSpotted, bool isMulticolored, bool isPredator)
            : base(name, age, habitat, weight, favoriteFood, gender, 4, 70, isSpotted, isMulticolored, isPredator)
        {
        }

        public void EatQuito()
        {
            Console.WriteLine($"{Name} sticks out it's tongue trying to eat quito");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is not moving an inch, waiting for it's moment to strike. Hide your kids, hide your wives, also she's camouflaging herself");
        }
    }
}