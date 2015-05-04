using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("napishete 2 chisla ");
            int a, b;
            Console.Write("a = ");
           a= int.Parse( Console.ReadLine());
           Console.Write("b = ");
           b = int.Parse(Console.ReadLine());
           Console.WriteLine("ostatuka a/b =" + (a%b));


        }
    }
}
