using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prg_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numerator");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the denominator");
            int q = int.Parse(Console.ReadLine());
            try
            {
                int r = p / q;
                Console.WriteLine("The value of Quotient is {0}", r);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Execution completed");
            }
            Console.ReadLine();
        }
    }
}
