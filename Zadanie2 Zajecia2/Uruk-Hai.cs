using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2_Zajecia2
{
    class UrukHai
    {
        int hp = 3000;
        int atak = 50;

        public int BijWroga()
        {
            return atak;
        }
        
        public int Blizard()
        {
            return 75;
        }

        public int Hp {
            get
            {
                return hp;
            }
        }
        public int PrzyjmijObrazenia(int obrazenia)
        {
            hp -= obrazenia;
            if (hp <= 0)
            {
                return 0;
            }
            return hp;
        }
    }
}
