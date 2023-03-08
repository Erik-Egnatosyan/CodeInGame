namespace CountYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                string b = inputs[0];
                string d = inputs[1];
                int a = Convert.ToInt32(b.Substring(b.Length - 4));
                int z = Convert.ToInt32(d.Substring(d.Length - 4));
                Console.WriteLine(z - a);
            }
        }
    }
}