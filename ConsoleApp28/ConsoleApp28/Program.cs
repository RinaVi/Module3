using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    { 
        static void Main(string[] args)
        {               
            
            Dictionary<string, string> saladMenu = new Dictionary<string, string>();
            Dictionary<string, string> piesMenu = new Dictionary<string, string>();
            Dictionary<string, string> cakesMenu = new Dictionary<string, string>();

            string choise = null;
            
            while (choise != "S")
            {
                Console.WriteLine("Please,choose the dish");
                Console.WriteLine("1-Salad" + "\n" + "2-Pies" + "\n" + "3-Cakes");
                Console.WriteLine("If you want to stop the adding press: S");
                choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":

                        Console.WriteLine("How many positions would you like to add?");
                        int saladPositions = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < saladPositions; i++)
                        {
                            Console.WriteLine("Please write new salad name and salad price");
                            Salad salad1 = new Salad(Console.ReadLine(), Console.ReadLine());
                            saladMenu.Add(salad1.Name, salad1.Price);
                        }
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine("How many positions would you like to add?");
                        int piesPositions = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < piesPositions; i++)
                        {
                            Console.WriteLine("Please write new pie name and pie price");
                            Pie pie1 = new Pie(Console.ReadLine(), Console.ReadLine());
                            piesMenu.Add(pie1.Name, pie1.Price);
                        }
                        Console.Clear();
                        break;
                    case "3":
                        Console.WriteLine("How many positions would you like to add?");
                        int cakesPositions = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < cakesPositions; i++)
                        {
                            Console.WriteLine("Please write new cake name and cake price");
                            Cake cake1 = new Cake(Console.ReadLine(), Console.ReadLine());
                            cakesMenu.Add(cake1.Name, cake1.Price);
                        }
                        Console.Clear();
                        break;
                }

            }

            foreach (KeyValuePair<string, string> salads in saladMenu)
            {
                Console.Write("Salad: " + salads.Key + " ");
                Console.WriteLine("$" + salads.Value);
            }
            foreach (KeyValuePair<string, string> pies in piesMenu)
            {
                Console.Write("Pie: " + pies.Key + " ");
                Console.WriteLine("$" + pies.Value);
            }
            foreach (KeyValuePair<string, string> cakes in cakesMenu)
            {
                Console.Write("Cake: " + cakes.Key + " ");
                Console.WriteLine("$" + cakes.Value);
            }


            object locker = new object();
            Dictionary<string, string> menuFortoday = new Dictionary<string, string>();

            Thread firstThread = new Thread(Add);
            firstThread.Start();
            
            Thread secondThread = new Thread(Remove);
            secondThread.Start();
            Console.ReadLine();

            void Add()
            {
               lock (locker)
                {
                    while (menuFortoday.Count < 50)
                    {
                        foreach (KeyValuePair<string, string> menu in menuFortoday)
                        {
                            foreach (KeyValuePair<string, string> salad in saladMenu)
                                menuFortoday.Add(salad.Key, salad.Value);
                            foreach (KeyValuePair<string, string> pie in piesMenu)
                                menuFortoday.Add(pie.Key, pie.Value);
                            foreach (KeyValuePair<string, string> cake in cakesMenu)
                                menuFortoday.Add(cake.Key, cake.Value);
                            Console.Write(menu.Key + " ");
                            Console.WriteLine("$" + menu.Value);
                            Thread.Sleep(5000);
                        }
                       
                    }
                }
                
            }
            void Remove()
            {
                Console.Clear();
                lock (locker)
                {
                    while (menuFortoday.Count < 32)
                    {
                        foreach (KeyValuePair<string, string> menu in menuFortoday)
                        {
                            foreach (KeyValuePair<string, string> salad in saladMenu)
                                menuFortoday.Remove(salad.Key);
                            foreach (KeyValuePair<string, string> pie in piesMenu)
                                menuFortoday.Remove(pie.Key);
                            foreach (KeyValuePair<string, string> cake in cakesMenu)
                                menuFortoday.Remove(cake.Key);
                            Console.Write(menu.Key + " ");
                            Console.WriteLine("$" + menu.Value);
                            Thread.Sleep(7000);
                        }

                    }
                }

            }

        }
        
    }
}
    
