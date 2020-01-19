using System;

namespace QuickSort
{
    class Program
    {
        public static void Main()
        {
            int[] arr = { 16, 7, 5, 8, 9, 1, 5 };
            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine("sorted array ");
            PrintArray(arr);
        }

        static void QuickSort(int[] arr, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int pIndex = Partition(arr, start, end);

            QuickSort(arr, start, pIndex - 1);
            QuickSort(arr, pIndex + 1, end);
        }

        static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];

            int pIndex = start;

            for (int j = start; j < end; j++)
            {
                if (arr[j] < pivot)
                {
                    Swap(arr, j, pIndex);
                    pIndex++;
                }
            }

            Swap(arr, pIndex, end);

            return pIndex;
        }

        static void Swap(int[] arr, int a, int b) // O(1)
        {
            if (a == b || arr[a] == arr[b])
            {
                return;
            }

            arr[a] = arr[a] ^ arr[b];
            arr[b] = arr[a] ^ arr[b];
            arr[a] = arr[a] ^ arr[b];
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }

    }
}