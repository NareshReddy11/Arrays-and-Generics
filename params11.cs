using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class params11
    {
        static int sum = 0;
       public int add(params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            params11 obj1 = new params11();
            obj1.add(2, 3, 7, 5, 4, 90, 67, 13, 90);
            Console.WriteLine("sum is:" + sum);
        }
    }
}