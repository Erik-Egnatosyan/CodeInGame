using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPT
{
    internal class GPTS
    {
        public void CountGlas()
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                //if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' || input[i] == 'y')
                //    count++;
                if (input[i] is 'a' or 'e' or 'i' or 'o' or 'u' or 'y')
                    count++;
                //if ("aeiouy".Contains(input[i]))
                //    count++;
            }
            Console.WriteLine($"Количество гласных: {count}");
        }
        public void FindMaxLength()
        {
            Console.Write("Введите список слов (разделенных пробелами): ");
            string[] input = Console.ReadLine().Split(' ');
            StringBuilder sb = new StringBuilder();
            int max = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length > max)
                {
                    max = input[i].Length;
                    sb.Clear();
                    sb.Append(input[i] + ", ");
                }
                else if (input[i].Length == max)
                {
                    sb.Append(input[i]);
                }
            }
            Console.WriteLine($"Самое длинное слово(а): {sb}");
        }
        public void Math()
        {
            Console.Write("Введите математическое выражение: ");
            string[] input = "20 + 30 + 50 / 10".Split(' ');
            StringBuilder sb = new StringBuilder();
            List<string> tempString = new List<string>();
            int temp = 0;
            FirstStep();
            SecondStep();
            Console.WriteLine(sb);
            void FirstStep()
            {
                tempString.Add(input[0]);
                for (int i = 1; i < input.Length - 1; i += 2)
                {
                    switch (input[i])
                    {
                        case "*":
                            temp = Convert.ToInt32(tempString[^1]) * Convert.ToInt32(input[i + 1]);
                            tempString[^1] = temp.ToString();
                            break;
                        case "/":
                            temp = Convert.ToInt32(tempString[^1]) / Convert.ToInt32(input[i + 1]);
                            tempString[^1] = temp.ToString();
                            break;
                        default:
                            tempString.Add(input[i]);
                            tempString.Add(input[i + 1]);
                            break;
                    }
                }
            }
            void SecondStep()
            {
                sb.Clear();
                temp = Convert.ToInt32(tempString[0]);
                for (int i = 1; i < tempString.Count; i += 2)
                {
                    switch (tempString[i])
                    {
                        case "+":
                            temp += Convert.ToInt32(tempString[i + 1]);
                            break;
                        case "-":
                            temp -= Convert.ToInt32(tempString[i + 1]);
                            break;
                        default:
                            break;
                    }
                }
                sb.Append(temp);
            }
        }
        public void Math2()
        {
            Console.Write("Введите математическое выражение: ");
            string input = Console.ReadLine();
            double result = Evaluate(input);
            Console.WriteLine("Результат: " + result);

            double Evaluate(string expression)
            {
                System.Data.DataTable table = new System.Data.DataTable();
                return Convert.ToDouble(table.Compute(expression, ""));
            }
        }
    }
}
