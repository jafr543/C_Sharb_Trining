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

            Console.WriteLine("Even Numbers: " + string.Join(", " , numbers.Where(n => n % 2 == 0)));
            Console.WriteLine("Odd Numbers: " + string.Join(", ", numbers.Where(n => n % 2 != 0)));
            Console.WriteLine("Numbers Greater Than Five: " + string.Join(", ", numbers.Where(n => n > 5)));
            Console.WriteLine("Every Second Number: " + string.Join(", ", numbers.Where((n, index) => index % 2 == 1)));
            Console.WriteLine("Half of the List: " + string.Join(", ", numbers.Where(n => n <= numbers.Count / 2)));

            Console.ReadKey();
        }
    }
}
