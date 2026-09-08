using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

class Program
{
    static string BitArrayToString(BitArray bitArray)
    {
        char[] chars = new char[bitArray.Length];
        for (int i = 0; i < bitArray.Length; i++)
        {
            chars[i] = bitArray[i] ? '1' : '0';
        }
        return new string(chars);
    }

    static void Main()
    {
        // Create two BitArrays
        BitArray bits1 = new BitArray(new bool[] { true, false, true, false });
        BitArray bits2 = new BitArray(new bool[] { true, true, true, false });


        Console.WriteLine("bits1 : " + BitArrayToString(bits1));
        Console.WriteLine("bits2 : " + BitArrayToString(bits2));
        Console.WriteLine("BitWise Operators:");


        // Bitwise AND operation
        BitArray resultAnd = new BitArray(bits1);
        resultAnd.And(bits2);


        Console.WriteLine("\nBitwise AND result: ");
        Console.WriteLine(BitArrayToString(bits1));
        Console.WriteLine(BitArrayToString(bits2));
        Console.WriteLine("------------");
        Console.WriteLine(BitArrayToString(resultAnd));


        // Bitwise Or operation
        BitArray resultOr = new BitArray(bits1);
        resultOr.Or(bits2);

        Console.WriteLine("\nBitwise OR result: ");
        Console.WriteLine(BitArrayToString(bits1));
        Console.WriteLine(BitArrayToString(bits2));
        Console.WriteLine("------------");
        Console.WriteLine(BitArrayToString(resultAnd));



        // Bitwise Or operation
        BitArray resultXor = new BitArray(bits1);
        resultOr.Xor(bits2);

        Console.WriteLine("\nBitwise XOR result: ");
        Console.WriteLine(BitArrayToString(bits1));
        Console.WriteLine(BitArrayToString(bits2));
        Console.WriteLine("------------");
        Console.WriteLine(BitArrayToString(resultAnd));

        Console.ReadKey();
    }
}

