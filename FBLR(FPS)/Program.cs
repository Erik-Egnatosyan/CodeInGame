namespace FBLR_FPS_
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int[] cords = {0,0};
        
        bool cord = false; // true for X, false for Y
        bool posneg = false; //true for neg, false for pos
        string path = "FFBFFBFFB";
        
        foreach (char el in path)
        {
            if (el == 'F')
                if (!posneg) cords[Convert.ToInt32(cord)]++;
                else cords[Convert.ToInt32(cord)]--;
            else if (el == 'B')
                if (!posneg) cords[Convert.ToInt32(cord)]--;
                else cords[Convert.ToInt32(cord)]++;
            
            else if (el == 'R')
            {
                if (cord)
                {
                    cord = !cord;
                    posneg = !posneg;
                }
                else
                    cord = !cord;
            }
            
            else if (el == 'L')
            {
                if (!cord)
                {
                    cord = !cord;
                    posneg = !posneg;
                }
                else
                    cord = !cord;
            }
            
        }
        Console.WriteLine($"{cords[1]}, {cords[0]}");
        }

    }
}