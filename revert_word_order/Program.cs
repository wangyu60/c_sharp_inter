using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revert_word_order
{
    class Program
    {
        static void Main(string[] args)
        {
            var original = "The quick brown fox jumps over the lazy dog";
            //target to should be "dog lazy the over jumps fox brow quick The"

            var result = Revert(original); //my version
            Console.WriteLine(result);

            var result2 = string.Join(" ", original.Split(' ').Reverse());
            Console.WriteLine(result2);
            Console.ReadLine();
        }

        private static object Revert(string original)
        {
            var builder = new StringBuilder();
            var subs = original.Split(' ');
            IEnumerable<string> enumerable = subs.Reverse();
            string[] objects = enumerable as string[] ?? enumerable.ToArray();
            foreach (var item in objects)
            {
                if (item != objects.Last())
                    builder.Append(item + " ");
                else
                    builder.Append(item);
            }


            return builder.ToString();
        }

    }
}
