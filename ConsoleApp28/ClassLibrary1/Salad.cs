using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    public class Salad : Dish
    {
        public Salad (string name, string price)
        {
            Name = name;
            Price = price;
        }
        //public void GetSalad()
        //{
           
        //    Console.WriteLine("Please write new salad name");
        //    Name = Console.ReadLine();
        //    Console.WriteLine("Please write new salad price");
        //    Price = Console.ReadLine();
        //}
        int shelfLife = 5;
        
    }
}
