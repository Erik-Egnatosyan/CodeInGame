using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PrimeNumberCouter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            bool[] primes = new bool[n + 1];
            int count = 0;
            for (int i = 2; i <= n; i++)
            {
                primes[i] = true;
            }
            for (int i = 2; i * i <= n; i++)
            {
                for (int j = i * i; j <= n; j += i)
                {
                    primes[j] = false;
                }
            }
            for (int i = 2; i <= n; i++)
            {
                if (primes[i])
                {
                    count++;
                }
            }
            Console.WriteLine("\nКоличество простых чисел: " + count);
        }
    }
}