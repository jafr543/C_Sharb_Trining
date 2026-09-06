using System;
using System.Collections.Generic;

namespace Trining
{
    internal class Program
    {

        public static void Main()
        {

            // List initialization
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            // Adding an element at the end
            numbers.Add(11);
            Console.WriteLine("After adding 11: " + string.Join("_", numbers));


            // Inserting an element at a specific position
            numbers.Insert(numbers.Count, numbers.Count + 1);
            Console.WriteLine("After inserting items number + 1 at the end: " + string.Join("_", numbers));


            // Inserting multiple elements
            numbers.InsertRange(5, new List<int> { 55, 56 });
            Console.WriteLine("After inserting 55 and 56 at index 5: " + string.Join("_", numbers));



            Console.ReadKey();
        }
    }
}
