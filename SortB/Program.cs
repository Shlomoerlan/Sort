using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SortB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine(string.Join(",", BubbleSort([1, 5, 2, 4, 9, 3])));
            Console.WriteLine(string.Join(",", SelectionSort([1, 5, 2, 4, 9, 3])));
        }
        public static int[] BubbleSort(int[] nums)
        {
            for (int j = 0; j < nums.Length; j ++)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        int temp = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = temp;
                    }
                }
            }
            return nums;
        }

        public static int[] SelectionSort(int[] nums)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] > nums[j])
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            return nums;
        }
    }
}