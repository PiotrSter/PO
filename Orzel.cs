using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwierzaki
{
    class Orzel: Zwierze
    {
        public string imie;
        public int waga, rozmiar;
        public new void CoJem()
        {
            Console.WriteLine("Jem gryzonie.");
        }

        public new void JakSiePoruszam()
        {
            Console.WriteLine("Ja latam.");
        }
    }
}
