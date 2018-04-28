using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    public class Dish
    {
        public string Name { get; set; }
        public string Price { get; set; }
    }
    public class Salad : Dish
    {
        int shelfLife = 5;
    }
    public class Pies : Dish
    {
        int shelfLife = 3;
    }
    public class Cakes : Dish
    {
        int shelfLife = 7;
    }
}
