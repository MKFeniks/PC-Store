﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCStore.Classes
{
    public class Part
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Part()
        {

        }

        public Part(string name ,double price)
        {
            Name = name;
            Price = price;
        }
    }
}
