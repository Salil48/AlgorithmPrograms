using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class MergeSort
    {
        public static void Merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;
            int[] left = new int[n1];
            int[] right = new int[n2];
            int i, j;
            for (i = 0; i < n1; ++i)
            {
                left[i] = arr[l + i];
            }
            for (j = 0; j < n2; ++j)
            {
                right[j] = arr[m + 1 + j];
            }

            i = 0;
            j = 0;
            int k = l;
            while (i < n1 && j < n2)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = left[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }
        //Sorting method
        public static void Sort(int[] arr, int l, int r)
        {
            if (l < r)
            {

                int m = (l + r) / 2;
                Sort(arr, l, m);
                Sort(arr, m + 1, r);
                Merge(arr, l, m, r);
            }
        }
        public static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}