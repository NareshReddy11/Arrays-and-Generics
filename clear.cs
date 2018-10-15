using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class clear
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 6, 95, 45, 32, 13, 28, 94, 86, 73 };
            Console.WriteLine("the initilization array is");
            for(int i=0;i<a.Length;i++)
            {
                Console.Write(a[i] + ",");
            }
            Array.Clear(a,2,6);
            Console.WriteLine("\n after clear the array");
            for(int i=0;i<a.Length;i++)
            {
                Console.Write(a[i] + ",");
            }
        }
    }
}
