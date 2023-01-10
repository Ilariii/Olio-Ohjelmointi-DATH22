using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albumi
{
    internal class luokka
    {
        public string albuminnimi;
        public string artisti;
        public string genre;

        private List<Kappale> kappaleet = new List<Kappale>();


        public Albumi(string albuminNimi, string artisti, string genre)
        {
            this.albuminNimi = 
            this.artisti = artisti
            this.genre = genre
        }

        public void LisäKappale(kappale uusiKappale)
        {
            kappaleet.Add(uusiKappale);

        }

        public void TulostaTiedot()
        {
            Console.WriteLine();
            Console.WriteLine("Albumi");
            Console.WriteLine(" -Artisti: " + artisti);
            Console.WriteLine(" -Albumin Nimi: " + albuminNimi);
            Console.WriteLine(" -Genre: " + genre);
            Console.WriteLine("Songs:");


            foreach (kappale kappale in kappaleet)
            {
                kappale.TulostaTiedot();
            }
        }
    }
}
