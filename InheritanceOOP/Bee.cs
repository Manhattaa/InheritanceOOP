using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOOP
{
    internal class Bee : Insect
    {
        public Bee(string name, int age, string habitat, double weight, string favoriteFood, string gender, bool isSpotted, bool isMulticolored, bool isPredator)
            : base(name, age, habitat, weight, favoriteFood, gender, 6, 1, isSpotted, isMulticolored, isPredator)
        {
        }

        public void Flutter()
        {
            Console.WriteLine($"{Name} flutters its wings.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} soars the skies scouting for nectar and his oddly tall human girlfriend.");
        }
    }
}
