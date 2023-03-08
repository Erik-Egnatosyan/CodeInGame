using System.Text;

namespace PrintCharAndUpperOrLowerChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello World";
            StringBuilder sb = new StringBuilder();
            sb.Append(s);
            for (int i = 0; i < sb.Length; i++)
            {
                Console.Write(sb[i]);
                if (char.IsLower(sb[i]))
                    Console.Write(sb[i].ToString().ToUpper());
                else if (char.IsUpper(sb[i]))
                    Console.Write(sb[i].ToString().ToLower());
            }
        }
    }
}