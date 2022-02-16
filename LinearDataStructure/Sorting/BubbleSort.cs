using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructure.Sorting
{
    public class BubbleSort
    {
        /* 
        Bubble Sort
        Big O Notation => Time Complexity of the below algorthim
        In the below method We check each element present in the array in iterative.

        Best case : O(n) (If it is presented in sorted array)
        Worst case : O(n*n) (If it is present in descending order)
        */
        public int[] BubbleSorting(int[] arr)
        {
            // Sort the given array in to ascending order
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }


    }
}
