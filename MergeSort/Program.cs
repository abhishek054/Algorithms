using System;
using System.Linq;

namespace MergeSort
{
    class MergeSort
    {
        public static void Main()
        {
            int[] arr = { 76, 89, 23, 1, 55, 78, 99, 12, 65, 100 };
            Console.WriteLine("Merge Sort");
            Console.Write("Initial array is: ");
            Print(arr, arr.Length);
            MergeSorting(arr, 0, arr.Length - 1);
            Console.Write("\nSorted Array is:  ");
            Print(arr, arr.Length);
        }

        static void MergeSorting(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int mid = start + ((end - start) / 2);
                MergeSorting(arr, start, mid);
                MergeSorting(arr, mid + 1, end);
                Merge(arr, start, mid, end);
            }
        }

        static void Merge(int[] arr, int start, int mid, int end)
        {
            int i, j, k;
            int sizeLeft = mid - start + 1;
            int sizeRight = end - mid;
            int[] L = new int[sizeLeft];
            int[] R = new int[sizeRight];

            for (i = 0; i < sizeLeft; i++)
                L[i] = arr[start + i];

            for (j = 0; j < sizeRight; j++)
                R[j] = arr[mid + 1 + j];

            i = j = 0;
            k = start;
            while (i < sizeLeft && j < sizeRight)
            {
                if (L[i] <= R[j])
                    arr[k++] = L[i++];

                else
                    arr[k++] = R[j++];
            }
            while (i < sizeLeft)
                arr[k++] = L[i++];
            
            while (j < sizeRight)
                arr[k++] = R[j++];
        }

        static void Print(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
