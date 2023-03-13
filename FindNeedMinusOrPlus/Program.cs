namespace FindNeedMinusOrPlus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] a = "1067 78 15463".Split(' ');
            string[] b = "-2465 579 4795".Split(' ');
            int temp = 0;
            if (Convert.ToInt32(a[0].ToString()) > Convert.ToInt32(b[0].ToString()))
            {
                temp = Convert.ToInt32(a[0].ToString()) - Convert.ToInt32(b[0].ToString());
                Console.WriteLine($"x={a[0]}-{temp}*t");
            }
            else
            {
                temp = Convert.ToInt32(b[0].ToString()) - Convert.ToInt32(a[0].ToString());
                Console.WriteLine($"x={a[0]}+{temp}*t");
            }
            if (Convert.ToInt32(a[1].ToString()) > Convert.ToInt32(b[1].ToString()))
            {
                temp = Convert.ToInt32(a[1].ToString()) - Convert.ToInt32(b[1].ToString());
                Console.WriteLine($"y={a[1]}-{temp}*t");
            }
            else
            {
                temp = Convert.ToInt32(b[1].ToString()) - Convert.ToInt32(a[1].ToString());
                Console.WriteLine($"y={a[1]}+{temp}*t");
            }
            if (Convert.ToInt32(a[2].ToString()) > Convert.ToInt32(b[2].ToString()))
            {
                temp = Convert.ToInt32(a[2].ToString()) - Convert.ToInt32(b[2].ToString());
                Console.WriteLine($"y={a[2]}-{temp}*t");
            }
            else
            {
                temp = Convert.ToInt32(b[2].ToString()) - Convert.ToInt32(a[2].ToString());
                Console.WriteLine($"y={a[2]}+{temp}*t");
            }
            Console.WriteLine("-2465 579 4795");
        }
    }
}