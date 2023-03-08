namespace Count_And_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string l = "+++++---++-++-+++--+++++-+--++";
            int count = 0;
            string temp = "";
            for (int i = 0; i < l.Length; i++)
            {
                if (l[i] == '+')
                {
                    count++;
                    temp = "";
                }
                else if (l[i] == '-')
                {
                    if (temp == "")
                    {
                        temp = "-";
                    }
                    else if (temp != "")
                    {
                        count++;
                        temp = "";
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}