using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class paramsObject
    {
        public void display(params object[] items)
        {
            for(int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
        static void Main(string[] args)
        {
            paramsObject obj1 = new paramsObject();
            obj1.display("naresh", "mahesh", 22, 100.6, 'w');
        }
    }
}
