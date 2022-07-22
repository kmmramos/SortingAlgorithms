namespace Sorts.Logic
{
    public static class MergeSort
    {

        /* merges 2 subarrays of [] arr
         * first subarray is arr[ l .. m ]
         * second subarray is arr[ m + 1 .. r ] */
        public static void Merge(int[] arr, int l, int m, int r)
        {
            /* find sizes of two
             * subarrays to be merged */
            int sizeOfLeft = m - l + 1;
            int sizeOfRight = r - m;

            /* create temp arrays */
            int[] L = new int[sizeOfLeft];
            int[] R = new int[sizeOfRight];

            int i, j;

            /* copy data to temp arrays */
            for (i = 0; i < sizeOfLeft; ++i)
            {
                L[i] = arr[l + i];
            }
            for (j = 0; j < sizeOfRight; ++j)
            {
                R[j] = arr[m + 1 + j];
            }

            /* merge the temp arrays */

            /* initial indexes of first
             * and second subarrays */
            i = 0;
            j = 0;

            /* initial index of merged
             * subarray array */
            int k = l;
            while (i < sizeOfLeft && j < sizeOfRight)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            /* copy remaining elements
             * of L[] if any */
            while (i < sizeOfLeft)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            /* copy remaining elements
             * of R[] if any */
            while (j < sizeOfRight)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        public static void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                /* find the middle point */
                int middle = left + (right - left) / 2;

                /* sort first & second halves */
                Sort(arr, left, middle);
                Sort(arr, middle + 1, right);

                /* merge the sorted halves */
                Merge(arr, left, middle, right);
            }
        }

        public static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
