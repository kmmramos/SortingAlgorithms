
namespace Sorts.Logic
{
    public static class QuickSort
    {
        /* the main function that implements QuickSort
         *      arr[]   --> array to be sorted
         *      low     --> starting index
         *      high    --> ending index */
        public static void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                /* pi is partitioning index, arr[p]
                 * is now at right place */
                int pi = Partition(arr, low, high);

                /* separately sorts elements 
                 * before partition and after partition */
                Sort(arr, low, pi - 1);
                Sort(arr, pi + 1, high);
            }
        }

        /* this function takes last element as pivot
         * places the pivot element at its correct position
         * places all smaller (than pivot) to left
         * and all greater to right */
        static int Partition(int[] arr, int low, int high)
        {
            // pivot
            int pivot = arr[high];

            /* index of smaller element
             * and indicates the right position of pivot so far */
            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                /* if current element is
                 * smaller than the pivot */
                if (arr[j] < pivot)
                {
                    /* increment index of smaller element */
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, high);
            return (i + 1);
        }

        /* a utility function to swap 2 element */
        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        /* function that prints an array */
        public static void PrintArray(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
