using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_override
{
    class Program
    {
        static void Main(string[] args)
        {
            var chi = new Chiwawa();
            chi.Bark();
        }
    }

    class Animal
    {
        public virtual void Bark()
        {
         Console.WriteLine("Bark");   
        }
    }

    class Dog : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("Woof!");
        }

        
    }

    class Chiwawa : Dog
    {
        public new void Bark()
        {
            Console.WriteLine("Chiwawa");
        }
        
    }

}
