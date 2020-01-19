using System;

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
            int n1 = mid - start + 1;
            int n2 = end - mid;
            int[] L = new int[n1];
            int[] R = new int[n2];
            for (i = 0; i < n1; i++)
            {
                L[i] = arr[start + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = arr[mid + 1 + j];
            }
            i = 0;
            j = 0;
            k = start;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k++] = L[i++];
                }
                else
                {
                    arr[k++] = R[j++];
                }
            }
            while (i < n1)
            {
                arr[k++] = L[i++];
            }
            while (j < n2)
            {
                arr[k++] = R[j++];
            }
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
