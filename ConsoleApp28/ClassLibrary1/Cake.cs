using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    public class Cake : Dish
    {
        public Cake(string name, string price) : base(name, price)
        {

        }

        int shelfLife = 7;
    }
}
