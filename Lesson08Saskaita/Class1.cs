using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08Saskaita
{
    public class Saskaita
    {
        public string Gavejas { get; set; }
        public string Siuntejas { get; set; }
        public int MoketiVisa { get; set; }
        public string SaskaitosNumeris { get; }

        public Saskaita(string gavejas, string siuntejas, int moketivisa)
        {
            Gavejas = gavejas;
            Siuntejas = siuntejas;
            MoketiVisa = moketivisa;
            SaskaitosNumeris = $"NR_{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}";
        }

    }
}
