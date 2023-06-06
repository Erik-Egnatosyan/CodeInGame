namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            int[] result = TwoSum(nums, 5);
            Console.WriteLine($"[{result[0]},{result[1]}]");
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] ints = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        ints[0] = i;
                        ints[1] = j;
                    }
                }
            }
            return ints;
        }
    }
}