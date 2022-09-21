using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Sukurti struktūrą Palmė. Publiclaukai: amziusir vaisiuKiekis. Abu tik skaitymui. Sukurti publicmetodą Prideti1MenAmziaus(). 
 * Palmė duoda vaisius nuo 5 iki 12 menėsio, paskui miršta, t.y. amžius tampa 0. VaisiuKiekis= amžius*3;
 * 
 * */
namespace Lesson08_02
{
    internal class Palme
    {
        public int Amzius { get; set; } 
        public int VaisiuKiekis { get; set; }   

        public Palme(int amzius)
        {
            Amzius = amzius;
            if (amzius < 5 || amzius > 12)
            {
                VaisiuKiekis = 0;
            }
            else
            {
                VaisiuKiekis = amzius * 3;
            }
        }

        public void RecalculateVaisiuKiekis()
        {
            if (Amzius < 5 || Amzius > 12)
            {
                VaisiuKiekis = 0;
            }
            else
            {
                VaisiuKiekis = Amzius * 3;
            }
        }
        public void PridedamVienaMenesi()
        {
            Console.WriteLine("Pridedam prie amziaus viena menesi");
            Amzius += 1;
            RecalculateVaisiuKiekis();
        }

    }
}
