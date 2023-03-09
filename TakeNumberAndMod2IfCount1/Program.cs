namespace TakeNumberAndMod2IfCount1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = "6";
            int sum = 0;
            if(number.Length != 1)
            {
                for (int i = 0; i < number.Length; i++)
                {
                    sum += Convert.ToInt32(number[i].ToString());
                    if (sum.ToString().Length > 1 && i == number.Length - 1)
                    {
                        number = sum.ToString();
                        sum = 0;
                        i = -1;
                    }
                }
                Console.WriteLine(sum);
            }
            else
            {
                sum = Convert.ToInt32(number);
                Console.WriteLine(sum%=2);
            }
                
        }
    }
}