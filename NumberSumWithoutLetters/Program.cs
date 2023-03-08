namespace NumberSumWithoutLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _string = "a1s2d3f4";
            int sum = 0;
            for (int i = 0; i < _string.Length; i++)
            {
                if (Char.IsDigit(_string[i]))
                    sum += int.Parse(_string[i].ToString());
            }
            Console.WriteLine(sum);
        }
    }
}