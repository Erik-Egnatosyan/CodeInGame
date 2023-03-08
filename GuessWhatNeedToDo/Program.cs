namespace GuessWhatNeedToDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs;
            inputs = Console.ReadLine().Split(' ');
            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                string dir = inputs[0];
                int dist = int.Parse(inputs[1]);
                if (dir == "N")
                    y += dist;
                else if (dir == "E")
                    x += dist;
                else if (dir == "S")
                    y -= dist;
                else if (dir == "W")
                    x -= dist;
            }

            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine($"{x} {y}"); 
        }
    }
}