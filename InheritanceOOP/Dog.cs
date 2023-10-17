using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOOP
{
    internal class Dog : Mammal
    {
        public Dog(string name, int age, string habitat, double weight, string favoriteFood, string gender, bool isSpotted, bool isMulticolored, bool isPredator)
            : base(name, age, habitat, weight, favoriteFood, gender, isSpotted, isMulticolored, isPredator)
        {
        }

        public void WagTail()
        {
            Console.WriteLine($"{Name} is wagging it's tail, happy to see you.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is a good boy, he lets out a happy bark!");
        }
    }
}