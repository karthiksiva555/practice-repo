using System;

namespace SortingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 20, 9, 16, 3, 2 };
            //var array = new int[]{5, 20, 9, 1, 16, 3, 2 };
            //var array = new int[] { 20, 9};
            //var array = new int[] { -3,-20, -9 };
            var sort = new Sort(array);

            //// Bubble Sort
            //sort.PrintArray();
            //sort.BubbleSort();
            //sort.PrintArray();

            //// Selection Sort
            //sort.PrintArray();
            //sort.SelectionSort();
            //sort.PrintArray();

            //// Selection Sort
            //sort.PrintArray();
            //sort.InsertionSort();
            //sort.PrintArray();

            // Bucket Sort
            //var bucketArray = new int[] { 20, 10, 60, 90, 30, 40, 70 };
            //sort.ArrayToSort = bucketArray;
            //sort.BucketSort();
            //sort.PrintArray();

            // Merge Sort
            //var mergeArray = new int[] { 10, 3, 2, 5, 8, 4, 3, 1, 2, 9, 7, 8 };
            //sort.ArrayToSort = mergeArray;
            //sort.PrintArray();
            //sort.MergeSort();
            //sort.PrintArray();

            // Quick Sort
            //var quickArray = new int[] { 9, 4, 6, 3, 7, 1, 2, 11, 5 };
            //sort.ArrayToSort = quickArray;
            //sort.QuickSort();
            //sort.PrintArray();

            // min Heap 
            var heapArray = new int[] { 10, 5, 30, 15, 50, 5, 25, 35, 1 };
            var heap = new Heap(heapArray.Length);

            foreach (var heapval in heapArray)
                heap.InsertNodeInHeap(heapval);
            heap.ShowHeap();
            while (!heap.IsHeapEmpty())
            {
                var root = heap.ExtractFromHeap();
                Console.WriteLine($"The Extracted value is : {root}");
                heap.ShowHeap();
            }

            // Heap Sort
            // in the above code, we inserted random numbers but as it is min heap, only min of all values can be returned at a time
            // so extract all the elements of the heap = >will return in sorted order

            Console.ReadLine();
        }
    }
}
