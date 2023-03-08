namespace Codeingame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            string[] inputs = Console.ReadLine().Split(' ');
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < N; i++)
            {
                int s = int.Parse(inputs[i]);
                if (s == 1)
                    count1++;
                else if (s == 2)
                    count2++;
                if (int.Parse(inputs[^1]) == 1)
                    count1++;
                if (int.Parse(inputs[^1]) == 2)
                    count2++;
            }

            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            if (count1 > count2)
                Console.WriteLine(1);
            else
                Console.WriteLine(2);
        }
    }
}