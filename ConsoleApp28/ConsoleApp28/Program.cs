using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Salad> saladMenu = new List<Salad>();

            List<Pies> piesMenu = new List<Pies>();

            List<Cakes> cakesMenu = new List<Cakes>();

            Console.WriteLine("Please,choose the dish");
            Console.WriteLine("1-Salad" + "\n" + "2-Pies" + "\n" + "3-Cakes");
            var choise = Console.ReadLine();

            switch (choise)
            {
                case "1":
                    Console.WriteLine("How many positions would you like to add?");
                    int saladPositions = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < saladPositions; i++)
                    {
                        Console.WriteLine("Please write new salad name and salad price");
                        saladMenu.Add(new Salad(Console.ReadLine(), Console.ReadLine()));
                    }
                    break;
                case "2":
                    Console.WriteLine("How many positions would you like to add?");
                    int piesPositions = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < piesPositions; i++)
                    {
                        Console.WriteLine("Please write new Pies name and Pies price");
                        piesMenu.Add(new Pies(Console.ReadLine(), Console.ReadLine()));
                    }
                    break;
                case "3":
                    Console.WriteLine("How many positions would you like to add?");
                    int cakesPositions = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < cakesPositions; i++)
                    {
                        Console.WriteLine("Please write new Pies name and Pies price");
                        cakesMenu.Add(new Cakes(Console.ReadLine(), Console.ReadLine()));
                    }
                    break;

            }
            //foreach (Salad salads in saladMenu)
            //{
            //    Console.Write("Salad: " + salads.Name + " ");
            //    Console.WriteLine("$" + salads.Price);
            //}
            //foreach (Cakes cakes in cakesMenu)
            //{
            //    Console.Write("Cakes: " + cakes.Name + " ");
            //    Console.WriteLine("$" + cakes.Price);
            //}
            //foreach (Pies pies in piesMenu)
            //{
            //    Console.Write("Pies": " + pies.Name + " ");
            //    Console.WriteLine("$" + pies.Price);
            //}

            Console.ReadLine();
        }
    }
}
