using System;
namespace TriningApp
{

    class Calcuator
    {
        private string P_Opirtion = string.Empty;
        private int P_Number = 0;
        private int P_PreviousNumber = 0;
        
       public void Add(int Number)
        {
            P_Opirtion = "Adding";
            P_PreviousNumber = Number;
            P_Number += Number;
        }

       public void Subtract(int Number)
        {
            P_Opirtion = "Subtrating";
            P_PreviousNumber = Number;
             P_Number -= Number;
        }

       public void Multiply(int Number)
        {
            P_Opirtion = "Multiplying";
            P_PreviousNumber = Number;
             P_Number *= Number;
        }

       public void Divide(int Number)
        {
            P_Opirtion = "Dividing";
            P_PreviousNumber = Number;
            if (Number <= 0)
            {
                P_Number /= 1;
            }
            else
            {
                P_Number /= Number;
            }
            
        }


       public void Clear()
        {
            P_Opirtion = "Clear";
            P_PreviousNumber = 0;
            P_Number = 0;
        }

       public void PrintResult()
        {
            Console.WriteLine("Result After {0} {1} is : {2}",P_Opirtion, P_PreviousNumber,P_Number);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcuator calculator1 = new Calcuator();

            calculator1.Add(10);
            calculator1.PrintResult();

            calculator1.Add(100);
            calculator1.PrintResult();

            calculator1.Subtract(20);
            calculator1.PrintResult();

            calculator1.Divide(0);
            calculator1.PrintResult();

            calculator1.Divide(2);
            calculator1.PrintResult();

            calculator1.Multiply(3);
            calculator1.PrintResult();

            calculator1.Clear();
            calculator1.PrintResult();


            Console.ReadLine();
        }
    }
        
}
