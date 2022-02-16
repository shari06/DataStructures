using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructure.Sorting
{
    public class SelectionSort
    {
        /* 
        Selection Sort
        Big O Notation => Time Complexity of the below algorthim
        In the below method there will be two arrays one will be sorted another will be an unsorted array
        Always we will select element form usorted array to sorted array

        Best case : O(n) (If it is presented in sorted array)
        Worst case : O(n*n) (If it is present in descending order)
        */
        public int[] SelectionSorting(int[] arr)
        {
            // Sort the given array in to ascending order
            for (int i = 0; i < arr.Length; i++)
            {
                int m_index = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[m_index])
                    {
                        m_index = j;
                    }
                }
                var temp = arr[m_index];
                arr[m_index] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }
    }
}
