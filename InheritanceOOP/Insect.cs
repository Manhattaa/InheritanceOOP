using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOOP
{
    internal class Insect : Animal
    {
        public Insect(string name, int age, string habitat, double weight, string favoriteFood, string gender, int numberOfLegs, int maxAge, bool isSpotted, bool isMulticolored, bool isPredator)
            : base(name, age, habitat, weight, favoriteFood, gender, numberOfLegs, maxAge, isSpotted, isMulticolored, isPredator)
        {
        }
    }
}
