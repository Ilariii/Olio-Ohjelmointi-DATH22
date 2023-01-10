using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_5_laskin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float summa;
            summa = Laskin.Summa(10, 1);
            Console.WriteLine(summa);
            float erotus = Laskin.Erotus(15, 8);
            Console.WriteLine(erotus);
            float kerto;
            kerto = Laskin.Kertolasku(10, 5);
            Console.WriteLine(kerto);
            float jako;
            jako = Laskin.Jako(12, 13);
            Console.WriteLine(jako);
        }
    }
}