﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOOP
{
    internal class Orchid : Flower
    {
        public Orchid(string name, int age, string habitat, double weight, string favoriteFood, bool isMulticolored)
            : base(name, age, habitat, weight, favoriteFood, isMulticolored)
        {
        }
    }
}