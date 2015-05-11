using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_for_less5_number1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("napishete EDNA cifra   ot 0 do cifra 9");
            int a;
            a = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Nula/Zero");
            }
            else if (a == 1)
            {
                Console.WriteLine("Edno/One");
            }
            else if (a == 2)
            {
                Console.WriteLine("Dve/Two");
            }
            else if (a == 3)
            {
                Console.WriteLine("Tri/Tree");
            }
            else if (a == 4)
            {
                Console.WriteLine("Chetri/Four");
            }
            else if (a == 5)
            {
                Console.WriteLine("Pet/Five");
            }
            else if (a == 6)
            {
                Console.WriteLine("Shest/Six");
            }
            else if (a == 7)
            {
                Console.WriteLine("Sedem/Seven");
            }
            else if (a == 8)
            {
                Console.WriteLine("Osem/Eight");
            }
            else if (a == 9)
            {
                Console.WriteLine("Devet/Nine");
            }
            else
            {
                Console.WriteLine("NE NAPRAI TVA DE TREA / YOU DID NOT DO THAT I WAS SUPPOSED TO ");
            }
        }
    }
}
