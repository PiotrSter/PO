using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW6
{
    class Programista: Pracownik
    {
        public override void Pracuj()
        {
            base.Pracuj();
            Console.WriteLine("Obowiązki programisty.");
        }
    }
}
