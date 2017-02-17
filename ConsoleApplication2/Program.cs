using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    // From http://stackoverflow.com/a/756083/1132522
    public class Program
    {
        public static void Main()
        {
            string str = "12";
            char[] arr = str.ToCharArray();
            Permute(arr, 0);
        }

        private static void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            char tmp = a;
            a = b;
            b = tmp;
        }


        private static void Permute(char[] elements, int recursionDepth)
        {
            var maxDepth = elements.Length - 1;

            if (recursionDepth == maxDepth)
            {
                Console.WriteLine(elements);
                return;
            }

            for (int i = recursionDepth; i <= maxDepth; i++)
            {
                Swap(ref elements[recursionDepth], ref elements[i]);
                Permute(elements, recursionDepth + 1);
                // backtrack
                Swap(ref elements[recursionDepth], ref elements[i]);
            }
        }
    }
}
