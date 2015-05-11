using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_for_less5_number2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" napisete si tochkite ot 1 do 9");
            int a ;
            a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1 :
                case 2 :
                case 3: Console.WriteLine(" umnojeno po 5 e =  "); Console.WriteLine(a = a * 5); break;
                case 4 :
                case 5 :
                case 6: Console.WriteLine("umnojeno po 10 = "); Console.WriteLine(a = a * 10); break;
                case 7 :
                case 8 :
                case 9: Console.WriteLine("umnojeno po 50 e = "); Console.WriteLine(a = a * 50); break;
                default: Console.WriteLine(" NE SI NAPISAL TVA DE TREBA "); break;
            }



        }
    }
}
