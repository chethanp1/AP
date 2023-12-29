using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prg_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String:");
            string orinalstr = Console.ReadLine();
            string reversestr = string.Empty;
            for (int i = orinalstr.Length - 1; i >= 0; i--)
            {
                reversestr += orinalstr[i];
            }
            Console.WriteLine("Result:" + reversestr);
            Console.ReadLine();

        }
    }
}
