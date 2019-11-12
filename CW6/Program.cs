using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pracownik> pracownicy = new List<Pracownik>();
            pracownicy.Add(new Programista());
            pracownicy.Add(new Projektant());
            pracownicy.Add(new Ksiegowy());

            foreach(Pracownik i in pracownicy)
            {
                Console.WriteLine($"{i}");
                i.Pracuj();
            }

            Console.ReadKey();
        }
    }
}
