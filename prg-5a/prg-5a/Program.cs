using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prg_5a
{
    public abstract class Program
    {
        public abstract int mul(int a, int b);
            public void displ()
            {
                Console.WriteLine("Abstract class program");
            }
    }
    public class demo:Program
    {
        public override int  mul(int a, int b)
        {
            return a * b;
        }
    }
    public class main
    {
        public static void Main()
        {
            demo d=new demo();
            int j=d.mul(20,30);
            Console.WriteLine("\n***********************************");
            Console.WriteLine("The Multiplication of {0} *{1}={2}",20,30,j);
            Console.WriteLine("\n*****************************");
            Console.ReadLine();
        }
    }
}
