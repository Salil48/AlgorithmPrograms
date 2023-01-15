using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class InsertionSort<T> where T : IComparable
    {
        public void Sort(T[] array)
        {
            int i, j;

            for (i = 1; i < array.Length; i++)
            {
                T value = array[i];
                j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(value) > 0))
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = value;
            }
        }
        public void PrintArray(T[] arr)
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
