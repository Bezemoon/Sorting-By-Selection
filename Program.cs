using System;

namespace SortingBySelection
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array = {-156, 141, 35, 94, 88, 61, 111};
            
            SelectionSort selectionSort = new SelectionSort();
            int[] sortedArray = selectionSort.Sort(array);
            foreach (var value in sortedArray)
            {
                Console.Write($"\t{value}");
            }
        }
    }
}