using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("napishete dve chisla.strani na triugulnik = a,b");
            int a, b;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(" a * b = " + (a * b));
            Console.WriteLine("S na triugulnika e = na " + ((a * b) / 2));
        }

    }
}
