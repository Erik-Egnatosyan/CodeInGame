namespace UNOCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = "4 blue 7 blue 7 yellow 7 green 0 green 1 green 1 green 1 red".Split(' ');
            int count = 0;
            string tempNumber = inputs[0];
            string tempColor = inputs[1];
            for (int i = 2; i < inputs.Length; i++)
            {
                string number = inputs[i];
                string color = inputs[++i];
                if (!(tempNumber == number || tempColor == color))
                    count++;
                tempNumber = number;
                tempColor = color;
                Console.WriteLine($"{number} {color}");
            }
            Console.WriteLine(count == 0 ? "Correct" : $"Incorrect count is {count}");
        }
    }
}