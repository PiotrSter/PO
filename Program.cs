using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Wojownik woj1 = new Wojownik("Aragorn", 100, 20, 20);
            Lucznik luk1 = new Lucznik("Legolas", 100, 18, 20);

            woj1.toString();
            luk1.toString();
            Console.WriteLine("Aragorn atakuje: " + woj1.MocAtaku());
            Console.WriteLine("Legolas atakuje: " + luk1.MocAtaku());
            Console.WriteLine("Aragornowi zostaje: " + woj1.Zycie(85) + " punktów życia");
            Console.WriteLine("Legolasowi zostaje: " + luk1.Zycie(40) + " punktów życia");
            woj1.toString();
            luk1.toString();
            Console.WriteLine("Aragorn atakuje: " + woj1.MocAtaku());

            Console.ReadKey();
        }
    }
}
