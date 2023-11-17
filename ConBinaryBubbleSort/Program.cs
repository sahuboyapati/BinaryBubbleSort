using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConBinaryBubbleSort
{
    internal class Program
    {
        static int[] GenerateRandomArray(int size)
        {
            int[] arr = new int[size];
            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(100); // Generates random integers between 0 to 99
            }
            return arr;
        }

        // Function to perform Bubble Sort in descending order
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        // Swap elements if they are in the wrong order
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        // Function to check if the array is sorted correctly in descending order
        static bool IsSorted(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        // Function for Binary Search in a sorted array
        static int BinarySearch(int[] arr, int key)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == key)
                {
                    return mid;
                }
                if (arr[mid] < key)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1; // Key not found
        }

        static void Main(string[] args)
        {
            int size = 10; // Change this value to set the size of the array
            int[] arr = GenerateRandomArray(size);

            // Print original array
            Console.WriteLine("Original Array:");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Perform Bubble Sort
            BubbleSort(arr);

            // Check if the array is sorted correctly
            if (IsSorted(arr))
            {
                Console.WriteLine("Array sorted correctly using Bubble Sort in descending order:");
                foreach (int item in arr)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Array did not sort correctly.");
            }

            // Binary Search demonstration
            int key = arr[0]; // Change this value to search for a different key
            int result = BinarySearch(arr, key);
            if (result != -1)
            {
                Console.WriteLine($"Element {key} found at index {result}");
            }
            else
            {
                Console.WriteLine($"Element {key} not found in the array");
            }
Console.ReadKey();
        }
    }
}
