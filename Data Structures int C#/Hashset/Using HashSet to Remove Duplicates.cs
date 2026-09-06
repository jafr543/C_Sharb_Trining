using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Array with duplicate values
        int[] array = new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 };


        // Initializing a HashSet with the array
        HashSet<int> uniqueNumbers = new HashSet<int>(array);


        //Displaying the unique elements
        foreach (int number in uniqueNumbers)
        {
            Console.WriteLine(number);
        }


        // Waiting for a key press
        Console.ReadKey();
    }
}
