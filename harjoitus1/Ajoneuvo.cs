using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus1
{
    internal class Ajoneuvo
    {
        public string Nimi;
        public int Nopeus;
        public int Renkaat;

        public Ajoneuvo(string nimi, int nopeus, int renkaat)
        {
            Nimi = nimi;
            Nopeus = nopeus;
            Renkaat = renkaat;
        }

        public void TulostaData()
        {
            Console.WriteLine("Ajoneuvo " + Nimi);
            Console.WriteLine("Huippu nopeus " + Nopeus);
            Console.WriteLine("Renkaiden määrä " + Renkaat);
        }
    }
}
