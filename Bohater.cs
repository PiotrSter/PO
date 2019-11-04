using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Bohater
    {
        protected string imie;
        protected double zywotnosc;
        protected int punktyTaktyki;
        protected enum klasa {Wojownik, Łucznik};

        protected Bohater(string imie, double zywotnosc, int punktyTaktyki)
        {
            this.imie = imie;
            this.zywotnosc = zywotnosc;
            this.punktyTaktyki = punktyTaktyki;
        }



    }
}
