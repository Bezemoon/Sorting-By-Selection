using System;

namespace SortingBySelection.Properties
{
    public static class ArrayExtension
    {
        public static int[] Remove(this int[] array, int index)
        {
            return UpdateArray(OffsetLeftValue(array, index));
        }

        private static int[] OffsetLeftValue(int[] array, int index)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i > index)
                    array[i - 1] = array[i];
            }

            return array;
        }

        private static int[] UpdateArray(int[] array)
        {
            int[] newArray = new int[array.Length - 1];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }

            return newArray;
        }
    }
}