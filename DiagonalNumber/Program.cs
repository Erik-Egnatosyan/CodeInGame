namespace DiagonalNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);
            int[,] cube = new int[x * 2, x * 2];
            for (int d = 0; d < y; d++)
            {
                Console.WriteLine();
            }
            for (int i = 0; i < cube.GetLength(0); i++)
            {
                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    if (i == j || i + j == cube.GetLength(0) - 1)
                    {
                        Console.Write($"*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}