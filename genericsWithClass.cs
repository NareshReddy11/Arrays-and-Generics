using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class generics<t>
    {
        public generics(t msg)
        {
            Console.WriteLine(msg);
        }
    }
    class generics1
    {
        static void Main(string[] args)
        {
            generics<string> gen = new generics<string>("This is generic class");
            generics<int> genI = new generics<int>(101);
            generics<char> getCh = new generics<char>('I');
        }
    }
}