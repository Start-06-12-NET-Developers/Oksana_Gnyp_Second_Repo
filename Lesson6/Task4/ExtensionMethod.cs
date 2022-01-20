using System;

namespace Lesson6
{
    public static class ExtensionMethod
    {
        public static void SortArray(this int[] array)
        {
            int temporary;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temporary = array[i];
                        array[i] = array[j];
                        array[j] = temporary;
                    }
                }
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
