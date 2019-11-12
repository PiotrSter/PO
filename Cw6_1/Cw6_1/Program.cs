using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura K1 = new Kwadrat();
            Figura T1 = new Trojkat();

            Console.WriteLine(K1.Pole());
            Console.WriteLine(T1.Pole());

            Console.ReadKey();
        }
    }
}
