using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2_Zajecia2
{
    class Wojownik:Bohater
    {
        public Wojownik(int hp, int atak, Rasa rasa)
        {
            this.hp = hp;
            this.atak = atak;
            this.rasa = rasa;

        }

        public int RzutToporem()
        {
            return atak * 2;
        }
    }
}
