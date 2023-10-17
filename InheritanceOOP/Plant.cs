using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOOP
{
    internal class Plant
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Habitat { get; set; }
        public double Weight { get; set; }
        public string FavoriteFood { get; set; }
        public bool IsMulticolored { get; set; }

        public Plant(string name, int age, string habitat, double weight, string favoriteFood, bool isMulticolored)
        {
            Name = name;
            Age = age;
            Habitat = habitat;
            Weight = weight;
            FavoriteFood = favoriteFood;
            IsMulticolored = isMulticolored;
        }

        public virtual void Grow()
        {
            Console.WriteLine($"{Name} is growing.");
        }
    }
}
