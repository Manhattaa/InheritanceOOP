using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOOP
{
    internal class VenusFlyTrap : Plant
    {
        public VenusFlyTrap(string name, int age, string habitat, double weight, string favoriteFood, bool isMulticolored)
            : base(name, age, habitat, weight, favoriteFood, isMulticolored)
        {
        }

        public void CatchFly()
        {
            Console.WriteLine($"{Name} caught a fly.");
        }

        public override void Grow()
        {
            Console.WriteLine($"{Name} is a Venus Fly Trap and is growing.");
        }

        public void Speak()
        {
            Console.WriteLine($"{Name} says: i'm a friendly little plant, come visit me. Insects are especially welcome.'");
        }
    }
}