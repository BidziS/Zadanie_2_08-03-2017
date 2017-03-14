using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zadanie2_Zajecia2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mag mag = new Mag(100,110,Rasa.Człowiek);
            Wojownik wojownik = new Wojownik(300, 150, Rasa.Krasnolud);
            Rzezimieszek rzezimieszek = new Rzezimieszek(300,150,Rasa.Elf);

            UrukHai urukHai = new UrukHai();

            Console.WriteLine("Rozpoczyna się walka z bossem!\n\n");
            int cooldown = 0;
            int obrazenia = 0;
         
            List<Bohater> bohaterowie = new List<Bohater>();
            bohaterowie.Add(mag);
            bohaterowie.Add(wojownik);
            bohaterowie.Add(rzezimieszek);

            while(urukHai.Hp > 0 || (mag.SprawdzHp() == 0 && rzezimieszek.SprawdzHp() == 0 && wojownik.SprawdzHp() == 0))
            {
                if ((mag.Mana != 0 || urukHai.Hp > 0 )&& mag.SprawdzHp() > 0)              
                {
                    obrazenia = mag.RzucCzar();
                    Console.WriteLine("Mag rzuca czar! Zadaje {0} obrażeń Uruk-Hai. Pozostała mana: {1}. Uruk-Hai posiada: {2} hp", obrazenia, mag.Mana, urukHai.PrzyjmijObrazenia(obrazenia));
                }
                else if(urukHai.Hp > 0 && mag.SprawdzHp() > 0)
                {
                    obrazenia = mag.BijWroga();
                    Console.WriteLine("Mag atakuje! Zadaje {0} obrażeń Uruk-Hai. Uruk-Hai posiada: {1} hp", obrazenia, urukHai.PrzyjmijObrazenia(obrazenia));
                }
                if ((cooldown % 2 == 0 || urukHai.Hp > 0) && wojownik.SprawdzHp() > 0)
                {
                    obrazenia = wojownik.RzutToporem();
                    Console.WriteLine("Wojownik rzuca toporem! Zadaje {0} obrażeń Uruk-Hai. Uruk-Hai posiada: {1} hp", wojownik.RzutToporem(),  urukHai.PrzyjmijObrazenia(wojownik.RzutToporem()));
                }
                else if(urukHai.Hp > 0 && wojownik.SprawdzHp() > 0)
                {
                    obrazenia = wojownik.BijWroga();
                    Console.WriteLine("Wojownik atakuje! Zadaje {0} obrażeń Uruk-Hai. Uruk-Hai posiada: {1} hp", obrazenia, urukHai.PrzyjmijObrazenia(obrazenia));
                }
                if (urukHai.Hp > 0 && rzezimieszek.SprawdzHp() > 0)
                {
                    obrazenia = rzezimieszek.BijWroga();
                    Console.WriteLine("Rzezimieszek atakuje! Zadaje {0} obrażeń Uruk-Hai. Uruk-Hai posiada: {1} hp", obrazenia, urukHai.PrzyjmijObrazenia(obrazenia));
                }               

                if (cooldown % 3 == 0 && urukHai.Hp > 0)
                {
                    obrazenia = urukHai.Blizard();
                    Console.WriteLine("Uruk-Hai atakuje czarem obszarowym! Zadaje po {0} obrażeń całej drużynie. Mag posiada: {1} hp, Rzezimieszek posiada: {2} hp, Wojownik posiada: {3} hp", obrazenia, mag.PrzyjmijObrazenia(obrazenia), rzezimieszek.PrzyjmijObrazenia(obrazenia), wojownik.PrzyjmijObrazenia(obrazenia));
                }
                else if (urukHai.Hp > 0)
                {
                    obrazenia = urukHai.BijWroga();
                    Console.WriteLine("Uruk-Hai atakuje! Zadaje {0} obrażeń bohaterowi. {1} posiada: {2}", obrazenia, bohaterowie[cooldown%3].GetType().Name, bohaterowie[cooldown % 3].SprawdzHp());
                }
                Console.WriteLine("--------------------------------------------------------------------------------------------------------");

                cooldown++;

            }


            Console.WriteLine("Koniec bitwy");

            Console.ReadLine();

        }

    }

}
