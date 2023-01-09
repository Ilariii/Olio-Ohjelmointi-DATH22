using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace olio_ohjelmointi
{
    internal class Koira
    {
        public string Nimi;
        public string Rotu;
        public int Ikä;

        public void HaeTiedot()
        {
            Console.WriteLine("Koiran nimi on " + Nimi);
            Console.WriteLine("Koiran ikä on " + Ikä);
            Console.WriteLine("Koiran rotu on " + Rotu);


        }

        public void Hauku()
        {
            Console.WriteLine(Nimi + " woof woof");

        }
    }
}
