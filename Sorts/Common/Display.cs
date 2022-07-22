
using Sorts.Logic;

namespace Sorts.Common
{
    public static class Display
    {
        public static void Problem1()
        {
            try
            {
                Console.Write("Please enter the size of your array: ");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] nums = new int[size];
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write("Please enter your number: ");
                    nums[i] = Convert.ToInt32(Console.ReadLine());
                }

                int[] answer = BubbleSort.Sort(nums);
                Console.WriteLine("Here are the numbers when sorted by Bubble Sort: ");
                foreach (var item in answer)
                {
                    Console.Write(item + " ");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void Problem2()
        {
            try
            {
                Console.Write("Please enter the size of your array: ");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] nums = new int[size];
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write("Please enter your number: ");
                    nums[i] = Convert.ToInt32(Console.ReadLine());
                }

                int[] answer = SelectionSort.Sort(nums);
                Console.WriteLine("Here are the numbers when sorted by Selection Sort: ");
                foreach (var item in answer)
                {
                    Console.Write(item + " ");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void Problem3()
        {
            try
            {
                Console.Write("Please enter the size of your array: ");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] nums = new int[size];
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write("Please enter your number: ");
                    nums[i] = Convert.ToInt32(Console.ReadLine());
                }

                int[] answer = InsertionSort.Sort(nums);
                Console.WriteLine("Here are the numbers when sorted by Insertion Sort: ");
                foreach (var item in answer)
                {
                    Console.Write(item + " ");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void Problem4()
        {
            try
            {
                Console.Write("Please enter the size of your array: ");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] nums = new int[size];
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write("Please enter your number: ");
                    nums[i] = Convert.ToInt32(Console.ReadLine());
                }

                MergeSort.Sort(nums, 0, nums.Length - 1);
                MergeSort.PrintArray(nums);

                //int[] answer = InsertionSort.Sort(nums);
                //Console.WriteLine("Here are the numbers when sorted by Insertion Sort: ");
                //foreach (var item in answer)
                //{
                //    Console.Write(item + " ");
                //}
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
