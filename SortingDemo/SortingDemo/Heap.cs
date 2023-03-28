using System;

namespace SortingDemo
{
    public class Heap
    {
        public int[] HeapTree { get; set; }
        public int TreeSize { get; set; }

        public Heap(int size)
        {
            HeapTree = new int[size+1]; // size + 1 because we are skipping index 0
            TreeSize = 0;
        }

        public bool IsHeapFull() => HeapTree.Length == TreeSize;
        
        public bool IsHeapEmpty() => TreeSize == 0;

        public void ShowHeap()
        {
            Console.WriteLine("The current heap looks like...");
            Console.WriteLine("---------------------------------------------");
            //Array.ForEach(HeapTree, Console.WriteLine); // don't pring index 0 because its not part of heap
            for (var i = 1; i <= TreeSize; i++) Console.Write($"{HeapTree[i]} ");
            Console.WriteLine("\n---------------------------------------------");
        }

        public void SwapByIndex(int index1, int index2)
        {
            var temp = HeapTree[index1];
            HeapTree[index1] = HeapTree[index2];
            HeapTree[index2] = temp;
        }
        
        // Insert to tree
        public void InsertNodeInHeap(int value)
        {
            if (IsHeapFull()) Console.WriteLine("Heap is full!");
            HeapTree[++TreeSize] = value;
            HeapifyBottomToTop(TreeSize);
        }

        // Extract from tree

        public int ExtractFromHeap()
        {
            if (IsHeapEmpty())
            {
                Console.WriteLine("Cannot extract because Heap is empty!");
                return -1;
            }
            var rootNode = HeapTree[1];
            HeapTree[1] = HeapTree[TreeSize--];
            HeapifyTopToBottom(1);
            return rootNode;
        }
        
        // HeapifyBoottomToTop - called after insert
        public void HeapifyBottomToTop(int index)
        {   
            if (index <=1) return; // stop when root node is reached
            var parent = index / 2;

            if (HeapTree[index] < HeapTree[parent])
                SwapByIndex(index, parent);
            
            HeapifyBottomToTop(parent);
        }

        // HeapifyTopToBottom - called after extract
        public void HeapifyTopToBottom(int index)
        {   var leftIndex = 2 * index;
            var rightIndex = 2 * index + 1;
            var smallestChild = 0;
            if (TreeSize < leftIndex) return; // stop recursion when last node is reached
            //if there is only one child (which will be in the left side
            else if(TreeSize == leftIndex)
            {
                if (HeapTree[index] > HeapTree[leftIndex])
                    SwapByIndex(index, leftIndex);
                return;
            }
            else
            {
                smallestChild = (HeapTree[leftIndex] > HeapTree[rightIndex]) ? rightIndex : leftIndex;
                if(HeapTree[index]>HeapTree[smallestChild])
                    SwapByIndex(smallestChild, index);
            }
            HeapifyTopToBottom(smallestChild);
        }
        
        // Delete heap
        public void DeleteHeap() => HeapTree = null;


    }
}
