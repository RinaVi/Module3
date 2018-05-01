using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    public class Pies : Dish
    {
        public Pies (string name, string price)
        {
            Name = name;
            Price = price;
        }
        //public void GetPies()
        //{
        //    Console.WriteLine("Please write new pie name");
        //    Name = Console.ReadLine();
        //    Console.WriteLine("Please write new pie price");
        //    Price = Console.ReadLine();
        //}
        int shelfLife = 3;
    }
}
