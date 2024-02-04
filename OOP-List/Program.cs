using System;
using System.Collections.Generic;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            // List = data structure that represents a list of objects that can be accessed by index.
            //        Similar to array, but can dynamically increase/decrease in size
            //        using System.Collections.Generic;


            List<string> foods = new List<string>();

            foods.Add("Spaghetti");
            foods.Add("Sinigang");
            foods.Add("Adobo");
            foods.Add("Fries");

            //foods.Insert(0, "Sushi");
            //foods.Remove("Fries");
            //Console.WriteLine(foods.IndexOf("Adobo"));
            //Console.WriteLine(foods.LastIndexOf("Fries"));
            //Console.WriteLine(foods.Contains("Sinigang"));
            //foods.Sort();
            //foods.Reverse(); 
            //foods.Clear();
            string[] foodArray = foods.ToArray();

            foreach (string food in foodArray)
            {
                Console.WriteLine(food);
            }



            Console.ReadKey();
        }
    }
}