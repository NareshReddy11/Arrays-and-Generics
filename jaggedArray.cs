using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class jaggedArray
    {
        static void Main(string[] args)
        {
            int[][] a = new int[3][];
            a[0] = new int[4] { 2, 6, 8, 9 };
            a[1] = new int[2] { 3 ,7};
            a[2] = new int[5] { 0, 4, 5, 2, 7 };
            Console.WriteLine("jagged array is");
            for(int i=0;i<a.Length;i++)
            {
                for(int j=0;j<a[i].Length;j++)
                {
                    Console.Write(a[i][j] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
