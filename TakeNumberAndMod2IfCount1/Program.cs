namespace TakeNumberAndMod2IfCount1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = "72";
            int sum1 = DigitSumWidthRecursion(number);
            int sum2 = DigitSumWithoutRecursion(number);
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
        }
        public static int DigitSumWidthRecursion(string number)
        {
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += Convert.ToInt32(number[i].ToString());
            }

            if (number.Length == 1)
            {
                return sum % 2;
            }
            else if (sum.ToString().Length > 1)
            {
                return DigitSumWidthRecursion(sum.ToString());
            }
            else
            {
                return sum;
            }
        }
        public static int DigitSumWithoutRecursion(string number)
        {
            int sum = 0;
            if (number.Length != 1)
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
                return sum;
            }
            else
            {
                sum = Convert.ToInt32(number);
                return sum %= 2;
            }
        }
    }
}