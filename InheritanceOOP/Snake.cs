using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOOP
{
    internal class Snake : Reptile
    {
        public Snake(string name, int age, string habitat, double weight, string favoriteFood, string gender, bool isSpotted, bool isMulticolored, bool isPredator)
            : base(name, age, habitat, weight, favoriteFood, gender, 4, 70, isSpotted, isMulticolored, isPredator)
        {
        }

        public void EatWabbit()
        {
            Console.WriteLine($"{Name} wants to eat Big Chungus, but it knows it's easier said than done");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} hisses as it manages to see Robin Hood in the crowd.");
        }
    }
}
