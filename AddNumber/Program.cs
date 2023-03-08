namespace AddNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "qe234wqewq324erq";
            int sum = 0;
            string temp = "";
            for (int i = 0; i < sentence.Length; i++)
            {
                if (char.IsDigit(sentence[i]))
                {
                    temp += sentence[i];
                }
                else
                {
                    if (temp != "")
                    {
                        sum += int.Parse(temp);
                        temp = "";
                    }
                }
            }
            if (temp != "")
            {
                sum += int.Parse(temp);
            }

            Console.WriteLine(sum);
        }
    }
}