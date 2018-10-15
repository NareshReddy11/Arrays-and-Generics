using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class matricsaddition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter row seze");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter column size");
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[row, col];
            int[,] sum = new int [row, col];
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    Console.WriteLine("enter a values");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int[,] b = new int[row, col];
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    Console.WriteLine("enter b matrix values");
                    b[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("a matrix and b matrix addition is \n");
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    sum[i, j] = a[i, j] + b[i, j];
                    Console.Write(sum[i, j] + " ");
                }
                Console.WriteLine();
               
            }
            
        }
    }
}
