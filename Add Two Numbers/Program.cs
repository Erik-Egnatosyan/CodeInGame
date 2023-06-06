using System.Text;

namespace Add_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            x += 65;
            StringBuilder sb = new StringBuilder();
            for (int i = 65; i < x; i++)
            {
                sb.Append((char)i);
                sb.Append((char)(i + 32));
            }
            Console.WriteLine(sb);
        }
    }
}