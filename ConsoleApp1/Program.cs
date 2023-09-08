namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        int[] ints = { 0,0,0,0,1,0,0,0,0,1,1,0,0,0,0,1,0,0,0,0 };
        int count = 0;
        int col = 0;
        for (int i = 0; i < ints.Length; i++)
        {
            if (ints[i] == 1 && count == 0)
                count++;
            else if (count > 0 && ints[i] == 0)
                col++;
        }
        Console.WriteLine(col);
    }
}

