using System;
using System.Collections.Generic;

namespace SortingDemo
{
    public class Sort
    {
        public int[] ArrayToSort { get; set; }

        public Sort(int[] arrayToSort) 
        {
            this.ArrayToSort = arrayToSort;
        }

        public void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        public void PrintArray()
        {
            Console.WriteLine("The current state of the array is:");
            Console.WriteLine("--------------------------------------------");
            foreach (var val in this.ArrayToSort)
                Console.Write($" {val} ");
            Console.WriteLine("\n--------------------------------------------");
        }
        
        private List<int> BubbleSortList(List<int> arr)
        {
            for (var outer = arr.Count -1; outer >= 0; outer--)
            {
                for (var inner = 0; inner < outer; inner++)
                {
                    if (arr[inner] > arr[inner + 1])
                    {
                        var temp = arr[inner];
                        arr[inner] = arr[inner + 1];
                        arr[inner + 1] = temp;
                    }
                }
                //PrintArray();
            }

            return arr;
        }

        public void BubbleSort()
        {
            Console.WriteLine("Performing bubble sort...");
            BubbleSortPrivate(ArrayToSort);
        }

        private void BubbleSortPrivate(int[] arr)
        {
            for (var outer = arr.Length - 1; outer >= 0; outer--)
                for (var inner = 0; inner < outer; inner++)
                    if (arr[inner] > arr[inner + 1])
                        Swap(ref arr[inner], ref arr[inner + 1]);
        }

        public void SelectionSort()
        {
            Console.WriteLine("Performing Selection sort...");
            for (var outer = 0; outer < ArrayToSort.Length; outer++)
                for (var inner = outer+1; inner < ArrayToSort.Length; inner++)
                    if (ArrayToSort[inner] < ArrayToSort[outer])
                        Swap(ref ArrayToSort[inner], ref ArrayToSort[outer]);
        }

        public void InsertionSort()
        {
            Console.WriteLine("Performing Insertion sort...");

            for(var outer = 1; outer < ArrayToSort.Length; outer++)
                for(var inner = outer-1; inner>=0; inner--)
                    if (ArrayToSort[inner + 1] < ArrayToSort[inner])
                        Swap(ref ArrayToSort[inner + 1], ref ArrayToSort[inner]);
        }

        public void BucketSort()
        {
            // calculate no.of buckets
            var bucketCount = (int)Math.Ceiling(Math.Sqrt(ArrayToSort.Length));

            // find the max value of the array
            var maxValue = ArrayToSort[0];
            for (var i = 1; i < ArrayToSort.Length; i++)
                if (ArrayToSort[i] > maxValue)
                    maxValue = ArrayToSort[i];

            // create buckets
            var buckets = new List<int>[bucketCount];
            for (var i = 0; i < bucketCount; i++)
                buckets[i] = new List<int>();

            // iterate through array and add it to corresponding bucket
            for(var i =0; i< ArrayToSort.Length; i++)
            {
                var bucketNo = (int)Math.Ceiling((double)(ArrayToSort[i] * bucketCount) / maxValue)-1;
                buckets[bucketNo].Add(ArrayToSort[i]);
            }
            
            var result = new List<int>();
            // sort individual buckets
            for (int i = 0; i < bucketCount; i++)
            {
                buckets[i] = BubbleSortList(buckets[i]);
                result.AddRange(buckets[i]);
            }

            // print the result
            result.ForEach(Console.WriteLine);
            this.ArrayToSort = result.ToArray();
        }

        public void MergeSort()
        {
            Console.WriteLine("Performing Merge sort...");
            MergeRecursive(ArrayToSort, 0, ArrayToSort.Length - 1);
        }

        private void MergeSortedArrays(int[] arr, int left, int middle, int right)
        {
            //copy data into two seperate temporary arrays
            var leftTemp = new int[middle - left+2];
            var rightTemp = new int[right - middle+1];

            for (var i = 0; i <= middle - left; i++)
                leftTemp[i] = arr[left + i];
            for (var i = 0; i < right - middle; i++)
                rightTemp[i] = arr[middle +1+ i];

            leftTemp[middle - left + 1] = int.MaxValue;
            rightTemp[right - middle] = int.MaxValue;

            int l = 0, j = 0;
            for(var k = left; k <= right; k++)
            {
                if (leftTemp[j] < rightTemp[l])
                    arr[k] = leftTemp[j++];
                else
                    arr[k] = rightTemp[l++];
            }
        }

        private void MergeRecursive(int[] arr, int left, int right)
        {
            if (left < right) // Base Condition
            {
                var middle = (left + right) / 2;
                MergeRecursive(arr, left, middle);
                MergeRecursive(arr, middle + 1, right);
                MergeSortedArrays(arr, left, middle, right);

                //testing
                //PrintArray();
            }
        }

        public void QuickSort()
        {
            Console.WriteLine("Performing Quick sort...");
            QuickSortRecursive(ArrayToSort, 0, ArrayToSort.Length - 1);
        }

        public void QuickSortRecursive(int[] arr, int left, int right)
        {
            if (left >= right) return;

            var i = left-1; // calculating pivot index for current array range
            for(var j = left; j <= right; j++)
            {
                if (arr[j] <= arr[right])
                    Swap(ref arr[j], ref arr[++i]);
            }
            // pivot is at the index i
            QuickSortRecursive(arr, left, i - 1);
            QuickSortRecursive(arr, i+1, right);
        }
    }
}
