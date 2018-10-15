using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class reSize
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 6, 4, 8, 3, };
            Console.WriteLine("array is");
            for (int i=0;i<a.Length;i++)
            {
                Console.Write(a[i] + ",");
            }
            Console.WriteLine("\n enter seze");
            int k=Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref a, k);
            Console.WriteLine("\n after reze");
            for (int i=0;i<a.Length;i++)
            {
                Console.Write(a[i] + ",");
            }

        }
    }
}
