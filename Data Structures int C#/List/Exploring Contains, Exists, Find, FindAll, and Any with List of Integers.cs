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
            List<int> numbers = new List<int> { 44, 22, -55, 666, 9, -6, 345, 11, 3, 3 };


            // Using Contains
            Console.WriteLine("List contains 9: " + numbers.Contains(100));


            // Using Exists
            Console.WriteLine("List contains numbers Less Than 1000: " + numbers.Exists(n => n > 1000));


            // Using Find
            Console.WriteLine("First negative number: " + numbers.Find(n => n < 0));

            // Using Find
            Console.WriteLine("First Positive number: " + numbers.Find(n => n > 0));

            // Using FindAll
            Console.WriteLine("All negative numbers: " + string.Join(", ", numbers.FindAll(n => n < 0)));

            // Using FindAll
            Console.WriteLine("All Positive numbers: " + string.Join(", ", numbers.FindAll(n => n > 0)));

            // Using Any
            Console.WriteLine("Any numbers greater than 100: " + numbers.Any(n => n > 100));
            Console.ReadKey();
        }
    }
}
