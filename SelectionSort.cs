using SortingBySelection.Properties;

namespace SortingBySelection
{
    public class SelectionSort
    {
        private int[] _sortedArray;
        
        public int[] Sort(int[] array)
        {
            _sortedArray = new int[array.Length];

            for (int i = 0; i < _sortedArray.Length; i++)
            {
                int minValueIndex = FindMinimalValueIndex(array);
                _sortedArray[i] = array[minValueIndex];
                array = array.Remove(minValueIndex);
            }

            return _sortedArray;
        }

        private int FindMinimalValueIndex(int[] array)
        {
            int minValueIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[minValueIndex] > array[i])
                {
                    minValueIndex = i;
                }
            }

            return minValueIndex;
        }
    }
}