namespace DaysInMonth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.DaysInMonth(y,m));

        }
    }
}