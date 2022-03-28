using LinearDataStructure.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructure.BinarySearch
{
    public class BinarySearch
    {
        /* 
        Binary Search
        Big O Notation => Time Complexity of the below algorthim

        For implementing the Binary Search, We need to have a sorted array 
        In the below method we take the median element we can compare and move forward or backward baseed on the result

        Best case : O(1) (If it is present in first element of array)
        Worst case : O(log n) (If it is present in n element of array)
        */

        public int BinarySearching(int[] arr, int key)
        {
            // Sort the give array in to ascending order
            return BinarySearching(arr, key, 0, arr.Length - 1);
        }

        private int BinarySearching(int[] arr, int key, int i, int l)
        {
            var result = -1;
            if (i <= l)
            {
                if (i == l)
                {
                    if (arr[i] == key)
                    {
                        result = i;
                    }
                }
                else
                {
                    // To get the median form array i to l
                    var m = l + (i - l) / 2;
                    if (key == arr[m])
                    {
                        result = m;
                    }
                    // Search Key was present in the left side from median 
                    else if (arr[m] > key)
                    {
                        result = BinarySearching(arr, key, i, m - 1);
                    }
                    // Search Key was present in the Right side from median 
                    else if (arr[m] < key)
                    {
                        result = BinarySearching(arr, key, m + 1, l);
                    }

                }
            }
            return result;
        }

    }
}
