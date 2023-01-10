using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albumi
{
    internal class Albumi
    {
        static void Main(string[] args)
        {
            Albumi albumi = new Albumi("Evolve", "Imagine Dragons", "Poprock");

            albumi.LisääKappale(new kappale("Next to me", "3:50"));
            albumi.LisääKappale(new kappale("I Don't know why", "3:10"));
            albumi.LisääKappale(new kappale("What ever it takes", "3:21"));



            albumi.TulostaTiedot();
        }
    }
}
