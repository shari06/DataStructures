using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructure.LinearSearch
{
    public class LinearSearch
    {

        /* 
        Linear Search
        Big O Notation => Time Complexity of the below algorthim
        In the below method We check each element present in the array in iterative.

        Best case : O(1) (If it is present in first element of array)
        Worst case : O(n) (If it is present in n element of array)
        */

        public int LinearSearching(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
