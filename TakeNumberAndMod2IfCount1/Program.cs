namespace TakeNumberAndMod2IfCount1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string ns = n.ToString();
            string temp = "";
            int sum = 0;
            for (int i = 0; sum.ToString().Length > 1; i++)
            {
                if (sum.ToString().Length != 0)
                    sum += Convert.ToInt32(ns[i].ToString());
                if (i == ns.Length - 1)
                    temp = sum.ToString();
                if (temp.Length > 1)
                    sum += Convert.ToInt32(temp[i].ToString());
                if (temp.Length == 1)
                    sum %= 2;
            }
            Console.WriteLine(sum);
        }
    }
}