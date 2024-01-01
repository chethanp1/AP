using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prg_4B
{
    public delegate int deli(int n, int m);
    public class pgm9
    {
        public int sum(int a, int b)
            {
                return a + b;
            }
         public int diff(int a, int b)
            {
                return a - b;
            }
    }
    class program
    {
        static void Main(String[] argm)
        {
            pgm9 p1 = new pgm9();
            pgm9 p2 = new pgm9();
            deli d = p1.sum;
            int i = d(10, 20);

            deli f = p2.diff;
            int j = f(40, 20);

            Console.WriteLine("The sum is " + i + "\n difference is " + j);
            Console.ReadLine();
        }
    }
}
