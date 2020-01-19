using System;

namespace SelectionSort
{
    class SelectionSort
    {
        public static void Main()
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            Sort(arr);
            Console.WriteLine("Sorted array");
            PrintArray(arr);
        }

        static void Sort(int[] arr)
        {
            int n = arr.Length; // O(1)

            for (int i = 0; i < n - 1; i++) // O(n)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++) // O(n^2)
                {
                    if (arr[j] < arr[min_idx])
                    {
                        min_idx = j;
                    }

                }
                Swap(arr, i, min_idx); // O(1*n)
            }
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
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
