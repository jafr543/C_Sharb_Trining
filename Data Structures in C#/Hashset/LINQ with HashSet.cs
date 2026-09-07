using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Creating and populating a HashSet of integers
        HashSet<int> numbers = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


        // Using LINQ to filter out even numbers
        var evenNumbers = numbers.Where(n => n % 2 == 0);


        // Displaying the even numbers
        Console.WriteLine("Even Numbers:");
        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }

        // Using LINQ to filter out even numbers
        var oddNumbers = numbers.Where(n => n % 2 != 0);


        // Displaying the even numbers
        Console.WriteLine("Odd Numbers:");
        foreach (var number in oddNumbers)
        {
            Console.WriteLine(number);
        }


        // Using LINQ to find numbers greater than 5
        var numbersGreaterThanFive = numbers.Where(n => n > 5);


        // Displaying the numbers greater than 5
        Console.WriteLine("\nNumbers Greater Than 5:");
        foreach (var number in numbersGreaterThanFive)
        {
            Console.WriteLine(number);
        }


        // Creating and populating a HashSet of strings
        HashSet<string> names = new HashSet<string> { "Alice", "Bob", "Charlie", "Daisy", "Ethan", "Fiona" };


        // Using LINQ to filter names that start with 'C'
        var namesStartingWithC = names.Where(name => name.StartsWith("C"));


        // Displaying the names starting with 'C'
        Console.WriteLine("Names Starting with C:");
        foreach (var name in namesStartingWithC)
        {
            Console.WriteLine(name);
        }


        // Using LINQ to find names with length greater than 4 characters
        var namesLongerThanFour = names.Where(name => name.Length > 4);


        // Displaying the names longer than four characters
        Console.WriteLine("\nNames Longer Than Four Characters:");
        foreach (var name in namesLongerThanFour)
        {
            Console.WriteLine(name);
        }


        // Waiting for a key press
        Console.ReadKey();
    }
}
