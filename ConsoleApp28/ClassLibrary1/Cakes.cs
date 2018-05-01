using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    public class Cakes : Dish
    {
        public Cakes(string name, string price)
        {
            Name = name;
            Price = price;
        }
        //public void GetCakes()
        //{
        //    Console.WriteLine("Please write new cake name");
        //    Name = Console.ReadLine();
        //    Console.WriteLine("Please write new cake price");
        //    Price = Console.ReadLine();
        //}
        int shelfLife = 7;
    }
}
