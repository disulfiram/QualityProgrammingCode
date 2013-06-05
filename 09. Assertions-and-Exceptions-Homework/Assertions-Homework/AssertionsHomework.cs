using System;
using System.Linq;
using System.Diagnostics;

namespace AssertionsHomework
{
    public class AssertionsHomework
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "The array is null!");
            Debug.Assert(arr.Length > 0, "The array is empty!");
            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }
            for (int i = 1; i < arr.Length; i++)
            {
                Debug.Assert(arr[i - 1].CompareTo(arr[i]) < 0, "The array isn't sorted!");
            }
        }
   
        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "The array is null!");
            Debug.Assert(arr.Length > 0, "The array is empty!");
            Debug.Assert(startIndex >= 0, "Start index should be >= 0! Start index is " + startIndex);
            Debug.Assert(endIndex <= arr.Length - 1, "End index should be smaller than the length of the array! End index is " + endIndex);
            Debug.Assert(endIndex >= startIndex, "End index should be equal or bigger then Start index!");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            for (int j = startIndex; j <= endIndex; j++)
            {
                Debug.Assert(arr[minElementIndex].CompareTo(arr[j]) <= 0, "Minimum element Index is not correctly identified!");
            }

            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }

        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "The array is null!");
            Debug.Assert(arr.Length > 0, "The array is empty!");
            Debug.Assert(value != null, "Searched value is null!");
            for (int i = 1; i < arr.Length; i++)
            {
                Debug.Assert(arr[i - 1].CompareTo(arr[i]) < 0, "The array isn't sorted!");
            }

            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(startIndex >= 0, "Start index should be >= 0! Start index is " + startIndex);
            Debug.Assert(endIndex <= arr.Length - 1, "End index should be smaller than the length of the array! End index is " + endIndex);
            Debug.Assert(endIndex >= startIndex, "End index should be equal or bigger then Start index!");
            Debug.Assert(arr != null, "The array is null!");
            Debug.Assert(arr.Length > 0, "The array is empty!");
            Debug.Assert(value != null, "Searched value is null!");
            for (int i = 1; i < arr.Length; i++)
            {
                Debug.Assert(arr[i - 1].CompareTo(arr[i]) < 0, "The array isn't sorted!");
            }

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }
                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else 
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                Debug.Assert(!arr[i].Equals(value), "Searched value is found! The index of value cannot be -1!");
            }

            // Searched value not found
            return -1;
        }

        static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            SelectionSort(new int[0]); // Test sorting empty array
            SelectionSort(new int[1]); // Test sorting single element array

            Console.WriteLine(BinarySearch(arr, -1000));
            Console.WriteLine(BinarySearch(arr, 0));
            Console.WriteLine(BinarySearch(arr, 17));
            Console.WriteLine(BinarySearch(arr, 10));
            Console.WriteLine(BinarySearch(arr, 1000));
        }
    }
}
