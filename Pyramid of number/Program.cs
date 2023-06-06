internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("   x");
        Console.WriteLine("  x x");
        Console.WriteLine(" x x x");
        Console.WriteLine("x x x x");
        int x = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < x; i++)
        {
            for (int j = 1; j < x; j++)
            {
                if (!(j == x - 1))
                    Console.Write("");
                else
                    Console.Write("x");
            }
            Console.WriteLine("");
        }
    }
}