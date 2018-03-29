using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_of_string
{
    class Program
    {
        static void Main(string[] args)
        {
            var param = new List<string> { "Main" };
            M1(param);
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
            M2(ref param);
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static void M1(List<string> param)
        {
            //param = new List<string> ();
            param.Add("M1");
        }

        static void M2(ref List<string> param)
        {
            param = new List<string> { "M2" };
        }
    }

   
}
