namespace FibonachiNumberCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonachi fibonachi = new Fibonachi();
            fibonachi.Fiboncachiiii();
            string sequence = "0 1 1 2 3 5 8 13 21 34 55 89 144 233 ?";
            string[] sequence1 = sequence.Split(' ');
            int number = 0;
            int index = Array.IndexOf(sequence1, "?");
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence1.Length < 3)
                {
                    Console.WriteLine("Not Valid Input");
                    Environment.Exit(1);
                }
                else if (sequence.EndsWith('?'))
                    number = Convert.ToInt32(sequence1[^2].ToString()) + Convert.ToInt32(sequence1[^3].ToString());
                else if (sequence.StartsWith('?'))
                    number = Convert.ToInt32(sequence1[1].ToString());
                else if (sequence1.Length == 3)
                    number = Convert.ToInt32(sequence1[2].ToString()) - Convert.ToInt32(sequence1[0].ToString());
                else
                    number = Convert.ToInt32(sequence1[index - 1].ToString()) + Convert.ToInt32(sequence1[index - 2].ToString());
            }
            Console.WriteLine($"{sequence} where \"?\" equal {number}");
        }
    }
}