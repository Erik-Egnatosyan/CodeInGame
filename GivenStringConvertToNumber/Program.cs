namespace MonthsChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7 2022
            //2 2022
            //2 2024
            //13 2000
            //2 2028
            string[] inputs = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(inputs[0]);
            int y = Convert.ToInt32(inputs[1]);
            if (m >= 1 && m <= 12)
            {
                if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
                    Console.WriteLine(31);
                else if (m == 4 || m == 6 || m == 9 || m == 11)
                    Console.WriteLine(30);
                else if(m == 2 && y % 4 == 0)
                    Console.WriteLine(29);
                else
                    Console.WriteLine(28);
            }
            else
                Console.WriteLine("Invalid");
        }
    }
}