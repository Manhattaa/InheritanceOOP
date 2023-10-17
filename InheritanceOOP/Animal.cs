using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOOP
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Habitat { get; set; }
        public double Weight { get; set; }
        public string FavoriteFood { get; set; }
        public string Gender { get; set; }
        public int NumberOfLegs { get; set; }
        public int MaxAge { get; set; }
        public bool IsSpotted { get; set; }
        public bool IsMulticolored { get; set; }
        public bool IsPredator { get; set; }

        public Animal(string name, int age, string habitat, double weight, string favoriteFood, string gender, int numberOfLegs, int maxAge, bool isSpotted, bool isMulticolored, bool isPredator)
        {
            Name = name;
            Age = age;
            Habitat = habitat;
            Weight = weight;
            FavoriteFood = favoriteFood;
            Gender = gender;
            NumberOfLegs = numberOfLegs;
            MaxAge = maxAge;
            IsSpotted = isSpotted;
            IsMulticolored = isMulticolored;
            IsPredator = isPredator;
        }

        public Animal(string name, int age, string habitat, double weight, string favoriteFood, string gender, bool isSpotted, bool isMulticolored, bool isPredator)
        {
            Name = name;
            Age = age;
            Habitat = habitat;
            Weight = weight;
            FavoriteFood = favoriteFood;
            Gender = gender;
            IsSpotted = isSpotted;
            IsMulticolored = isMulticolored;
            IsPredator = isPredator;
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Name} is moving.");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} makes a generic animal sound.");
        }
    }
}