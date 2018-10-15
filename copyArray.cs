using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class copyArray
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 55, 4, 8, 9, 00, 1, };
            int[] b = { 23, 12, 40, 75, 88, 95, 13, 48, 68, 9 ,8,90};
            Console.WriteLine("a array elements");
            for(int i=0;i<a.Length;i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine("\n b array elements");
            for(int i=0;i<b.Length;i++)
            {
                Console.Write(b[i] + " ");
            }
            //a.CopyTo(b, 3);
            Array.Copy(a, b, 3);
          //  Array.Copy(a, 3, b, 5,2);
            Console.WriteLine("\n after copying array");
            for(int i=0;i<b.Length;i++)
            {
                Console.Write(b[i] + " ");
            }
        }
    }
}
