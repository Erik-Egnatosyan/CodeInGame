namespace UNOCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                string[] inputs = {"4 blue 7 blue 7 yellow 7 green 0 green 1 green 1 green 1 red"};
                string v = inputs[0];
                string c = inputs[1];
                if (!((c[i] == c[i - 1]) && (v[i] == v[i - 1])))
                {
                    count++;
                }
            }
            if (count == 0)
                Console.WriteLine("Correct");
            else
                Console.WriteLine($"Incorrect:{count}");
        }
    }
}