
namespace Sorts.Logic
{
    public static class QuickSelect
    {
        /* partition function similar to quickSort
         * considers last element as pivot &
         * adds element w/ less value to the left
         * & high value to the right
         * and also changes the pivot position
         * to its respective position in the readonly array */
        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high], pivotLoc = low, temp;
            for (int i = low; i <= high; i++)
            {
                /* inserting elements of less value
                 * to the left of the pivot location */
                if (arr[i] < pivot)
                {
                    temp = arr[i];
                    arr[i] = arr[pivotLoc];
                    arr[pivotLoc] = temp;
                    pivotLoc++;
                }
            }

            /* swapping pivot to the readonly pivot location */
            temp = arr[high];
            arr[high] = arr[pivotLoc];
            arr[pivotLoc] = temp;

            return pivotLoc;
        }

        /* finds the kth position of the sorted array
         * in a given unsorted array */
        public static int KthSmallest(int[] arr, int low, int high, int k)
        {
            /* find the partition */
            int partition = Partition(arr, low, high);

            /* if partition value is equal to the kth position
             * return value at K */
            if (partition == k)
                return arr[partition]; 

            /* if partition value is less than kth position
             * search right side of the array */
            else if (partition < k)
                return KthSmallest(arr, partition + 1, high, k);

            /* if partition value is more than kth position
             * search left side of the array */
            else
                return KthSmallest(arr, low, partition - 1, k);
        }
    }
}
