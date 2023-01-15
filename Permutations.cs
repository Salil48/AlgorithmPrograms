using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class Permutations
    {
        public static void Permutate(string str, int start, int end)
        {
            if (start == end)
            {
                Console.WriteLine(str);
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    str = (Swap(str, start, i));
                    Permutate(str, start + 1, end);
                    str = Swap(str, start, i);
                }
            }

        }
        public static string Swap(string word, int start, int end)
        {
            char temp;
            char[] charArray = word.ToCharArray();
            temp = charArray[start];
            charArray[start] = charArray[end];
            charArray[end] = temp;
            string s = new string(charArray);
            return s;

        }
    }
}