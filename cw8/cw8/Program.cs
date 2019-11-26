using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> imiona = new List<string>();
            ArrayList wiek = new ArrayList();
            List<Osoba> osoba = new List<Osoba>();

            Osoba o1 = new Osoba("Paweł", 18);

            imiona.Add("Mariusz");
            imiona.Add("Zosia");
            imiona.Add("Ania");
            imiona.Add("Ela");
            wiek.Add(23);
            wiek.Add(19);
            wiek.Add(22);
            wiek.Add(35);
            osoba.Add(new Osoba("Kasia", 20));
            osoba.Add(new Osoba("Karol", 33));
            osoba.Add(new Osoba("Tomek", 14));
            osoba.Add(o1);

            int ile = imiona.Count;
            int ile2 = wiek.Count;
            int ile3 = osoba.Count; 

            foreach(var i in imiona)
            {
                Console.WriteLine(i + " ");
            }



            foreach(var i in wiek)
            {
                Console.WriteLine(i + " ");
            }
            
            foreach(Osoba i in osoba)
            {
                Console.WriteLine($"Imie: {i.imie}, wiek: {i.wiek}");
            }

            osoba.Sort();

            foreach (Osoba i in osoba)
            {
                Console.WriteLine($"Imie: {i.imie}, wiek: {i.wiek}");
            }

            Console.ReadKey();
        }
    }
}
