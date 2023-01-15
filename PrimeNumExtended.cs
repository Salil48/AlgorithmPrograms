using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class PrimeNumExtended
    {
        public static int FindPrime(int num)
        {
            int half = num / 2, flag = 0;
            for (int i = 2; i <= half; i++)
            {
                if (num % i == 0)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                return flag;
            }
            return 0;
        }

        public static bool IsPalindrome(int num)
        {
            int rem, sum = 0, temp;
            temp = num;
            while (num > 0)
            {
                rem = num % 10;
                num = num / 10;
                sum = sum * 10 + rem;
            }
            if (temp == sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool FindAnagram(string string1, string string2)
        {

            char[] ch1 = string1.ToUpper().ToCharArray();
            char[] ch2 = string2.ToUpper().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string newString1 = new string(ch1);
            string newString2 = new string(ch2);
            if (newString1 == newString2)
            {

                return true;

            }
            else
            {

                return false;
            }
        }
    }
}