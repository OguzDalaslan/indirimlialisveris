using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelTekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, indirim, odenecek;
            Console.WriteLine("Alışveriş Tutarını Giriniz:");
            x = Convert.ToInt32(Console.ReadLine());
            if (x <100)
            {
                indirim = x * 10 / 100;
                odenecek = x - indirim;
                Console.WriteLine("Ödenecek tutar:" + odenecek);
            }
            if (x>=100 && x<150)
            {
                indirim = x * 15 / 100;
                odenecek= x - indirim;
                Console.WriteLine("Ödenecek tutar"+odenecek);
            }
            Console.ReadKey();
        }
    }
}
