using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class sort
    {
        static void Main(string[] args)
        {
            int[] a = { 44, 2, 8, 90, 1, 0, 34, 12, 32, 77 };
            Console.Write("before sorting \n");
            for(int i=0;i<a.Length;i++)
            {
                Console.Write(a[i] + ",");
            }
            Console.WriteLine("\n after sorting");
            //Array.Sort(a);
            Array.Sort(a, 4, 5);
            for (int i=0;i<a.Length;i++)
            {
                Console.Write(a[i] + ",");
            }
        }
    }
}
