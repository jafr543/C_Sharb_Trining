using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        ArrayList list = new ArrayList(); // Creating an ArrayList
        list.Add(10); // Adding elements
        list.Add("Hello");
        list.Add(true);
        list.Add(10.1345);


        Console.WriteLine("Total elements in ArrayList: " + list.Count);


        Console.WriteLine("Content of ArrayList using index:");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine("Index " + i + ": " + list[i]);
        }

        // Waiting for a key press
        Console.ReadKey();
        


    }
}
