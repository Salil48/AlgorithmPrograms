using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class BinarySearch<T> where T : IComparable
    {
        public static void BinarySearchWord(List<T> wordList)
        {
            //Initialize Local Variables
            int mid, start = 0;
            int end = wordList.Count - 1;
            bool isFound = false;
            Console.WriteLine("Enter the word to be searched in list");
            string key = Console.ReadLine();

            while (start <= end)
            {
                mid = (start + end) / 2;
                int result = key.CompareTo(wordList[mid]);
                if (result == 0)
                {
                    Console.WriteLine("Word is Present");
                    isFound = true;
                    break;
                }
                else if (result > 0)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("Word does not exist in Text File!");
            }

        }
    }
}