using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwierzaki
{
    class Program
    {
        static void Main(string[] args)
        {
            Pies pies1 = new Pies();
            Wilk wilk1 = new Wilk();
            Orzel orzel1 = new Orzel();
            Krokodyl krokodyl1 = new Krokodyl();
            Rekin rekin1 = new Rekin();

            Console.WriteLine("Pies:");
            pies1.CoJem();
            pies1.JakSiePoruszam();
            Console.WriteLine("Wilk:");
            wilk1.CoJem();
            wilk1.JakSiePoruszam();
            Console.WriteLine("Orzeł:");
            orzel1.CoJem();
            orzel1.JakSiePoruszam();
            Console.WriteLine("Krokodyl:");
            krokodyl1.CoJem();
            krokodyl1.JakSiePoruszam();
            Console.WriteLine("Rekin:");
            rekin1.CoJem();
            rekin1.JakSiePoruszam();

            Console.ReadKey();
        }
    }
}
