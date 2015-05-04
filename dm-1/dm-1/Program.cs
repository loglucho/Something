using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("napishete dve chisla");
            int a, b;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("sumata na a + b = "+(a+b));

        }
    }
}
