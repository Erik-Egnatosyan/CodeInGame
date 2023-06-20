using ChatGPT;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        GPTS gpt = new GPTS();
        //gpt.CountGlas();
        //gpt.FindMaxLength();
        //gpt.Math();
        //gpt.Math2();
        int a = 5;
        int b = 4;
        (b, a) = (a, b);
        Console.WriteLine(a);
    }
}