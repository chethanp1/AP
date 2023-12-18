using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            Console.WriteLine("Please enter the number1");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the number2");
            number2 = Convert.ToInt32(Console.ReadLine());
            int Result;
            Result = number1 + number2;
            Console.WriteLine("Sum of two numbers: " + Result.ToString());
            Console.ReadLine();
        }
    }
}
