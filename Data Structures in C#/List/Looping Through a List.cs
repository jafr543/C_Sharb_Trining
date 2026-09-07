using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Trining
{
    internal class Program
    {

        public static void Main()
        {

            List<string> Names = new List<string> { "Jafr", "Noor", "Jaber", "Ali", "Omar"};

            string AllNames = string.Empty;

            //Using For Loop to Print All List Items
            for(int i = 0; i < Names.Count; i++)
            {
                AllNames += ", " + Names[i];
            }
            Console.WriteLine("By Using For Loop: " + AllNames.Remove(0, 2));

            AllNames = string.Empty;

            // Using Foreach Loop to Print All List Items
            foreach (string name in Names)
            {
                AllNames += ", " + name;
            }
            Console.WriteLine("By Using Foreach Loop: " + AllNames.Remove(0, 2));

            AllNames = string.Empty;

            // Using the List.ForEach method
            Names.ForEach(name => AllNames += ", " + name);
            Console.WriteLine("By Using List.ForEach method: " + AllNames.Remove(0, 2));


            AllNames = string.Empty;
            int Counter = 0;

            // Using the List.ForEach method
            while (Counter < Names.Count)
            {
                AllNames += ", " + Names[Counter];
                Counter++;
            }
            Console.WriteLine("By Using While Loop: " + AllNames.Remove(0, 2));

            Console.ReadKey();
        }
    }
}
