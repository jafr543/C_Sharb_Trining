using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Creating and populating a HashSet of integers
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3,};
        HashSet<int> set2 = new HashSet<int> { 3, 3, 2, 5 };

        // Removing elements of set2 from set1
        set1.ExceptWith(set2);


        Console.WriteLine("Difference of sets (set1 - set2):");
        foreach (int item in set1)
        {
            Console.WriteLine(item);
        }


        // Waiting for a key press
        Console.ReadKey();
    }
}
