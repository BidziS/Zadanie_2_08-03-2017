using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2_Zajecia2
{
    abstract class Bohater:IBohater
    {
        protected int hp;
        protected int atak;
        protected Rasa rasa;

        public int BijWroga()
        {
            return atak;
        }
        public int SprawdzHp()
        {
            return hp;
        }
        public int PrzyjmijObrazenia(int obrazenia)
        {
            hp -= obrazenia;
            if (obrazenia <= 0)
            {
                hp = 0;
            }
            return hp;
        }

    }
    enum Rasa
    {
        Elf,
        Człowiek,
        Krasnolud

    }
    


}
