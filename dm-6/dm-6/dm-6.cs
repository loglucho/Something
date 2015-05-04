using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" napishete realno chislo i go razdelete na drugo cqlo chislo ");
            float a;
            int b;
            a = float.Parse( Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(+(a/b));

        }
    }
}
