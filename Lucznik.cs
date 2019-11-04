using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Lucznik: Bohater
    {
        public int zrecznosc;

        public Lucznik(string imie, double zywotnosc, int punktyTaktyki, int zrecznosc)
            :base(imie, zywotnosc, punktyTaktyki)
        {
            this.zrecznosc = zrecznosc;
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
            mocAtaku = zrecznosc * punktyTaktyki * zywotnosc;
            return mocAtaku;
        }

        public void toString()
        {
            Console.WriteLine($"Imie: {imie}, życie: {zywotnosc}, punkty taktyki: {punktyTaktyki}, zręcznosć: {zrecznosc}");
        }
    }
}
