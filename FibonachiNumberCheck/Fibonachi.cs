using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonachiNumberCheck
{
    internal class Fibonachi
    {
        public void Fiboncachiiii()
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int x = int.Parse(inputs[0]); 
            int y = int.Parse(inputs[1]);
            int a = x;
            int b = 1;

            while (a <= y)
            {
                Console.Write($"{a} ");
                int temp = a;
                a += b;
                b = temp;
            }
        }
    }
}
