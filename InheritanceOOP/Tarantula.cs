using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOOP
{
    internal class Tarantula : Spider
    {
        public Tarantula(string name, int age, string habitat, double weight, string favoriteFood, string gender, bool isSpotted, bool isMulticolored, bool isPredator)
            : base(name, age, habitat, weight, favoriteFood, gender, isSpotted, isMulticolored, isPredator)
        {
        }

        public void Crawl()
        {
            Console.WriteLine($"{Name} is crawling slowly.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} makes a hissing sound.");
        }
    }
}