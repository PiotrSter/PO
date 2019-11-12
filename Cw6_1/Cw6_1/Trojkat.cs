using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw6_1
{
    class Trojkat: Figura
    {
        public override int Pole()
        {
            return (bok2 * bok3) / 2;
        }
    }
}
