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

        //Checking if "Apple" are in the Hashset
        if (fruits.Contains("Apple"))
        {
            Console.WriteLine("element Is Exist");

        }
        else
        {
            Console.WriteLine("element Not Exist");
        }


        //Checking if "Orange" are in the Hashset
        if (fruits.Contains("Orange"))
        {
            Console.WriteLine("element Is Exist");

        }
        else
        {
            Console.WriteLine("element Not Exist");
        }


        // Waiting for a key press
        Console.ReadKey();
    }
}
