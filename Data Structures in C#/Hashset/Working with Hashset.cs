using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Creating a HashSet of strings
        HashSet<string> fruits = new HashSet<string>();


        // Adding elements to the HashSet
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Cherry");


        // Trying to add a duplicate element
        fruits.Add("Apple"); // This will not be added
        fruits.Add("Banana"); // This will not be added
        fruits.Add("Cherry"); // This will not be added


        // Displaying the elements in the HashSet
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        // Waiting for a key press
        Console.ReadKey();
    }
}
