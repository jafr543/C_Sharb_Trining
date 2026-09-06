using System;
using System.Collections.Generic;

namespace Trining
{
    internal class Program
    {

        public static void Main()
        {

            List<string> Names = new List<string> { "Jafr", "Noor", "Jaber", "Ali", "Omar"};

            // All List items
            Console.WriteLine("All List elements: " + string.Join(", ", Names));


            // Removing an item by value
            Names.Remove("Noor");
            Console.WriteLine("After removing Noor: " + string.Join(", ", Names));


            // Removing an item by index
            Names.RemoveAt(2);
            Console.WriteLine("After removing Third element: " + string.Join(", ", Names));


            // Removing multiple items
            Names.RemoveAll(n => n.StartsWith("J"));
            Console.WriteLine("After removing all Names That Beggin With Leter 'J': " + string.Join(", ", Names));


            // Clearing the list
            Names.Clear();
            Console.WriteLine("After clearing the list, count: " + Names.Count);



            Console.ReadKey();
        }
    }
}
