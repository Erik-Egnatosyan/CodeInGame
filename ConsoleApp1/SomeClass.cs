using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
internal class SomeClass : IDisposable
{
    public SomeClass()
    {
        Console.WriteLine("Mau");
    }

    public void Dispose()
    {
        Console.WriteLine("Im cleaning for you!");
    }
}
