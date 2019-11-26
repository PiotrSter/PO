using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw8
{
    class Osoba
    {
        public string imie;
        public int wiek;

        public Osoba(string imie, int wiek)
        {
            this.imie = imie;
            this.wiek = wiek;
        }

        public string PodajImie(string imie)
        {
            return imie;
        }

        public int PodajWiek(int wiek)
        {
            return wiek;
        }
    }
}
