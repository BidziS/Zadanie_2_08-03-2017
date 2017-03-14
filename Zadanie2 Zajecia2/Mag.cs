using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2_Zajecia2
{
    class Mag:Bohater
    {
        int mana = 100;

        public int Mana
        {
            get
            {
                return mana;
            }
        }

        public Mag(int hp, int atak, Rasa rasa)
        {
            this.hp = hp;
            this.atak = atak;
            this.rasa = rasa;

        }

        public int RzucCzar()
        {
            if (mana < 25)
            {
                Console.WriteLine("Za mało many by rzucić czar");
                return 0;
            }
            else
            {
                mana -= 25;
            }
            return atak * 3;

        }
        
    }
}
