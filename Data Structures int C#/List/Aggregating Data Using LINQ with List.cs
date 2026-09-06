using System;
using System.Collections.Generic;
using System.Linq;

namespace Trining
{
    internal class Program
    {

        public static void Main()
        {

            // List initialization
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            // Aggregation operations
            Console.WriteLine("Sum: " + numbers.Sum());
            Console.WriteLine("Average: " + numbers.Average());
            Console.WriteLine("Minimum: " + numbers.Min());
            Console.WriteLine("Maximum: " + numbers.Max());
            Console.WriteLine("Count: " + numbers.Count());

            Console.ReadKey();
        }
    }
}
