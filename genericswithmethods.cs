using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class genericswithmethods
    {
        public void set<t>(t nn)
        {
            Console.WriteLine(nn);
        }

    }
    class genericsWithMethods1
    {
        static void Main(string[] args)
        {
            genericswithmethods obj1 = new genericswithmethods();
            obj1.set("naresh is gud boy");
            obj1.set(1222);
            obj1.set(33.33);
            obj1.set(33.4f);
        }
    }
}
