﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    public class Salad : Dish
    {
        public Salad(string name, string price):base(name,price)
        {
            
        }
       
        int shelfLife = 5;
        
    }
}
