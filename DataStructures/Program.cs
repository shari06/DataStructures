using LinearDataStructure.BinarySearch;
using LinearDataStructure.LinearSearch;
using LinearDataStructure.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("============================");
            Console.WriteLine("Data Structures ");
            Console.WriteLine("============================");

            Console.WriteLine("Please enter \n1 for  Linear Search \n2 for  Binary Search \n3 for  Insertion Sort \n4 for  Selection Sort ");
            var key = Console.ReadLine();
            switch (key)
            {
                case "1":
                    LinearSearch linearSearch = new LinearSearch();
                    Console.WriteLine("\nPlease enter the array of integer value with comma seperated. ");
                    var lineararray = Console.ReadLine();
                    Console.WriteLine("\nPlease enter integer value to search. ");
                    var searchKey = Convert.ToInt32(Console.ReadLine());
                    var result = linearSearch.LinearSearching(Array.ConvertAll(lineararray.TrimEnd(',').Split(','), int.Parse), searchKey);
                    Console.WriteLine($"\n Index: {result} (-1 will be index if that element is not present in that list)");
                    break;
                case "2":
                    BinarySearch binarySearch = new BinarySearch();
                    Console.WriteLine("\nPlease enter the array of integer value with comma seperated. ");
                    var array = Console.ReadLine();
                    Console.WriteLine("\nPlease enter integer value to search. ");
                    searchKey = Convert.ToInt32(Console.ReadLine());
                    InsertionSort insertionSort = new InsertionSort();
                    var resultarray = insertionSort.InsertionSorting(Array.ConvertAll(array.TrimEnd(',').Split(','), int.Parse));
                    PrintArry(resultarray);
                    result = binarySearch.BinarySearching(resultarray, searchKey);
                    Console.WriteLine($"\nIndex: {result} (-1 will be index if that element is not present in that list)");
                    break;
                case "3":
                    insertionSort = new InsertionSort();
                    Console.WriteLine("\nPlease enter the array of integer value with comma seperated. ");
                    array = Console.ReadLine();
                    resultarray = insertionSort.InsertionSorting(Array.ConvertAll(array.TrimEnd(',').Split(','), int.Parse));
                    PrintArry(resultarray);
                    break;
                case "4":
                    SelectionSort selectionSort = new SelectionSort();
                    Console.WriteLine("\nPlease enter the array of integer value with comma seperated. ");
                    array = Console.ReadLine();
                    resultarray = selectionSort.SelectionSorting(Array.ConvertAll(array.TrimEnd(',').Split(','), int.Parse));
                    PrintArry(resultarray);
                    break;
                case "5":
                    BubbleSort bubbleSort = new BubbleSort();
                    Console.WriteLine("\nPlease enter the array of integer value with comma seperated. ");
                    array = Console.ReadLine();
                    resultarray = bubbleSort.BubbleSorting(Array.ConvertAll(array.TrimEnd(',').Split(','), int.Parse));
                    PrintArry(resultarray);
                    break;
            }




            Console.ReadKey();
        }


        public static void PrintArry(int[] arr)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < arr.Length; i++)
            {
                sb.Append($"{arr[i]},");
            }
            Console.WriteLine($"\nArray : {sb.ToString().TrimEnd(',')}");
        }
    }
}
