using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOOP
{
    internal class Rabbit : Mammal
    {
        public Rabbit(string name, int age, string habitat, double weight, string favoriteFood, string gender, bool isSpotted, bool isMulticolored, bool isPredator)
            : base(name, age, habitat, weight, favoriteFood, gender, isSpotted, isMulticolored, isPredator)
        {
        }

        public void Memes()
        {
            Console.WriteLine($"{Name} shows you a meme you haven't seen in a while.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} smiles at you menacingly, Then thanks you for running this program");
        }
    }
}