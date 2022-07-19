namespace Sorts.Logic
{
    public static class SelectionSort
    {
        public static int[] Sort(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                // set current index as minimum
                int min = i;
                int temp = array[i];
                for (int j = i + 1; j < length; j++)
                {
                    if (array[j] < array[min])
                    {
                        // update min if current is lower than what we had previously
                        min = j;
                    }
                }
                array[i] = array[min];
                array[min] = temp;
            }
            return array;
        }
    }
}