using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jag;
            int i, j, var, sum = 0;
            Console.WriteLine("Enter No of Rows: ");
            int row = int.Parse(Console.ReadLine());
            jag = new int[row][];
            for (i = 0; i < row; i++)
            {
                Console.WriteLine("Enter number of elements in row{0}:", i + 1);
                var = int.Parse(Console.ReadLine());
                jag[i] = new int[var];
                Console.WriteLine("Enter the {0} values : ", var);
                for (j = 0; j < var; j++)
                {
                    jag[i][j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine("Jag {0}[]:", jag.Length);
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < jag[i].Length; j++)
                {
                    Console.Write(jag[i][j]+" ");
                    sum = sum + jag[i][j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("sum of jagged array is :{0}", sum);
            Console.ReadLine();

        }
    }
}
 