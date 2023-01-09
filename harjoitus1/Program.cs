using harjoitus1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus


{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ajoneuvo ajoneuvo = new Ajoneuvo("Bugatti", 400, 4);

            ajoneuvo.TulostaData();
        }
    }
}


