using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class reverse
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 67, 90, 22, 34, 12, 21, 34, 54 };
            Console.WriteLine("before reverse order \n");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + ",");
            }
            Console.WriteLine("\n after reversing \n");
           // Array.Reverse(a);
            Array.Reverse(a, 3, 5);
            for(int i=0;i<a.Length;i++)
            {
                Console.Write(a[i] + ",");
            }
        }
    }
}
