using System.Globalization;

namespace NumberMinusNext
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split(' ');
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(inputs[i]);
                if (i == 0)
                {
                    Console.Write($"{m} ");
                    temp = m;
                }
                else
                    Console.Write($"{m -= temp} ");
            }
            //Nnumber is 10 and 15 75 21 99 23 56 10 48 62 1
        }
    }
}