﻿namespace ReverseElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FirstVariant();
            SecondVariant();
        }
        public static void FirstVariant()
        {
            char a = Convert.ToChar(Console.ReadLine());
            char b = Convert.ToChar(Console.ReadLine());
            string input = Console.ReadLine();
            string[] input2 = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == a)
                    input2[i] = b.ToString();
                else if (input[i] == b)
                    input2[i] = a.ToString();
                Console.Write(input2[i]);
            }
        }
        public static void SecondVariant()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string input = Console.ReadLine();
            Console.WriteLine(input.Replace(a,"1").Replace(b,a).Replace("1",b));
        }
    }
}