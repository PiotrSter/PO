using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwierzaki
{
    class Zwierze : IZwierze
    {
        public void CoJem()
        {
            Console.WriteLine("Nie wiem, ale na pewno cos jem.");
        }

        public void JakSiePoruszam()
        {
            Console.WriteLine("Nie wiem, ale na pewno jakos sie poruszam");
        }

        void IZwierze.CoJem()
        {
            
        }

        void IZwierze.JakSiePoruszam()
        {
            
        }

        




    }
}
