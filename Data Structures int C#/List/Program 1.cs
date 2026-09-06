using System;
using System.Collections.Generic;

namespace Trining
{
    internal class Program
    {

        public static void Main()
        {

            List<int> numbers = new List<int>();


            // Adding elements to the list
            numbers.Add(1); // Add 1 to the list
            numbers.Add(2); // Add 2 to the list
            numbers.Add(3); // Add 3 to the list
            numbers.Add(4); // Add 4 to the list
            numbers.Add(5); // Add 5 to the list


            // Displaying the total number of elements in the list
            Console.WriteLine("Number of items in the list: " + numbers.Count);

            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }

            // Modifying an element in the list
            Console.WriteLine("Changing the value of item 2 of the list to 500:");
            numbers[1] = 500; // Change the value of the second element to 500
            Console.WriteLine(numbers[1]); // Displays the new value of the second element (500)


            Console.ReadKey();
        }
    }
}
