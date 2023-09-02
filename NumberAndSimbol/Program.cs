using System.Text;

namespace NumberAndSimbol;

internal class Program
{
    static void Main(string[] args)
    {
        string D = ("12$ 3N 1\"").Replace(" ","");
        string tempNum = "";
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < D.Length; i++)
        {
            if (!char.IsNumber(D[i]))
            {
                for (int j = 0; j < Convert.ToInt32(tempNum); j++)
                {
                    sb.Append(D[i]);
                }
                tempNum = "";
            }
            else
                tempNum += D[i];
        }
        Console.WriteLine(sb);
    }
}
