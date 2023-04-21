namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 1, 2, 3, 4, 5, 6 };
            //int[] result = TwoSum(nums, 5);
            //Console.WriteLine($"[{result[0]},{result[1]}]");
            SquareCount();
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
        public static void SquareCount()
        {
            int x = 8;
            double sum = 0;
            for (int i = 0; i < x; i++)
            {
                sum += Math.Pow(i,2);
            }
            Console.WriteLine(sum);
        }
    }
}