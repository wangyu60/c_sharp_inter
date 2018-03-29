using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parent_child_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new B();
            Console.ReadLine();
        }
    }

    class A
    {
        public A()
        {
            Console.WriteLine("A");
        }
    }

    class B: A
    {
        public B()
        {
            Console.WriteLine("B");
        }
    }
}
