using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class BubbleSort<T> where T : IComparable
    {
        public static void BubbleSortInArray(T[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 2; i++)
            {
                for (int j = n - 1; j >= 1; j--)

                {
                    if (arr[j].CompareTo(arr[j - 1]) < 0)

                    {
                        // swap temp and arr[i]
                        T temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
            }
        }
        public static void PrintArray(T[] arr)
        {
            Console.WriteLine("The Sorted array Using Bubble Sort : ");
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write("\n");
        }
    }
}