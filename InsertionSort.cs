using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class InsertionSort
    {
        public void Sort(int[] arr)
        {
            int size = arr.Length;
            for (int i = 1; i < size; i++)
            {
                int k = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > k)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = k;
            }
        }
        public void PrintArray(int[] arr)
        {
            Console.WriteLine("The Sorted array is : ");
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write("\n");
        }
    }
}