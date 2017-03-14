using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2_Zajecia2
{
    class Rzezimieszek:Bohater
    {
        int energia = 100;

        public int Energia { get { return energia; } }

        public Rzezimieszek(int hp, int atak, Rasa rasa)
        {
            this.hp = hp;
            this.atak = atak;
            this.rasa = rasa;

        }


    }
}
