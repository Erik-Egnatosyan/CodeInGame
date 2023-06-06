internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int cityDist = int.MaxValue, citySalary = 0;
        string serial = "";
        for (int i = 0; i < n; i++)
        {
            string[] option = Console.ReadLine().Split(' ');

            if (option[1].Length < cityDist)
            {
                cityDist = option[1].Length;

                citySalary = int.Parse(option[2]);
                serial = option[0];

            }
            else if (option[1].Length == cityDist)
            {
                if (int.Parse(option[2]) > citySalary)
                {
                    citySalary = int.Parse(option[2]);
                    serial = option[0];
                }
            }
        }
    }
}