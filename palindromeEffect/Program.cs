namespace palindromeEffect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Never odd or even.";
            text = text.Replace(".", "");
            string text2 = text;
            text2 = text2.Replace(" ", "");
            string text3 = "";
            text2 = text2.ToLower();
            for (int i = text2.Length - 1; i >= 0; i--)
            {
                text3 += text2[i];
            }
            if (text3 == text2)
                Console.WriteLine($"complex palindrome, {text}");
            else
                Console.WriteLine($"not a complex palindrome, {text}");
        }
    }
}