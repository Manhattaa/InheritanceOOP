using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOOP
{
    internal class Spider : Insect
    {
        public Spider(string name, int age, string habitat, double weight, string favoriteFood, string gender, bool isSpotted, bool isMulticolored, bool isPredator)
            : base(name, age, habitat, weight, favoriteFood, gender, 8, 5, isSpotted, isMulticolored, isPredator)
        {
        }

        public void SpinWeb()
        {
            Console.WriteLine($"{Name} is spinning a web.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} makes a hissing sound.");
        }
    }
}