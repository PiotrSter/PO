using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Wojownik: Bohater
    {
        public int sila;

        public Wojownik(string imie, double zywotnosc, int punktyTaktyki, int sila)
            :base(imie, zywotnosc, punktyTaktyki)
        {
            this.sila = sila;
        }

        public double Zycie(double obrazenia)
        {
            zywotnosc = zywotnosc - obrazenia;
            if (zywotnosc < 0)
            {
                Console.WriteLine("Bohater nie żyje.");
            }
            else if (zywotnosc >= 100)
            {
                Console.WriteLine("Maksymalne zycie");
            }

            return zywotnosc;
        }

        public double MocAtaku()
        {
            double mocAtaku;
            if (zywotnosc < 20)
            {
                mocAtaku = sila * punktyTaktyki * 150;
            }
            else
            {
                mocAtaku = sila * punktyTaktyki * zywotnosc;
            }

            return mocAtaku;

        }

        public void toString()
        {
            Console.WriteLine($"Imie: {imie}, życie: {zywotnosc}, punkty taktyki: {punktyTaktyki}, sila: {sila}");
        }
    }
}
