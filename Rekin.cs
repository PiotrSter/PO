using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwierzaki
{
    class Rekin: Zwierze
    {
        public string imie;
        public int waga, rozmiar;
        public new void CoJem()
        {
            Console.WriteLine("Jem mniejsze ryby.");
        }

        public new void JakSiePoruszam()
        {
            Console.WriteLine("Ja pływam.");
        }
    }
}
