using System.Text;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "qwertvvvsvvavd";
            StringBuilder sb = new StringBuilder();
            sb.Append(text);
            int count = 0;
            for (int i = 0; i < sb.Length; i++)
            {
                if ((sb[i] == 'v') && (count != 1))
                {
                    sb[i] = 'w';
                    count++;
                }
            }
            sb.Replace('v', '\a');
            Console.WriteLine(sb);
        }
    }
}