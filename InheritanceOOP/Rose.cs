using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOOP
{
    internal class Rose : Flower
    {
        public Rose(string name, int age, string habitat, double weight, string favoriteFood, bool isMulticolored)
            : base(name, age, habitat, weight, favoriteFood, isMulticolored)
        {
        }
    }
}
