using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_kucuktur_ve_kucuk_esit_operatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Küçüktür operatörü : <
            //Küçük eşit operatörü : <=
            int sayi1 = 5;
            bool kontrolet = sayi1 < 4;
            int sayi2 = 4;
            bool kontrolet2 = sayi2 <= 4;
            Console.WriteLine(kontrolet);
            Console.WriteLine(kontrolet2);
            Console.ReadLine();
        }
    }
}
