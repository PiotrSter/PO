using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw4
{
    class Osoba
    {
        public string imie, nazwisko;
        public int rokUrodzenia;
        public string miejsceZamieszkania;
        
        public Osoba(string imie, string nazwisko, int rokUrodzenia, string miejsceZamieszkania)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
            this.miejsceZamieszkania = miejsceZamieszkania;
        }

        protected void WypiszInfo()
        {
            Console.WriteLine($"Imie: {imie}, Nazwisko: {nazwisko}, rok urodzenia:{rokUrodzenia}");
        }

        public int ObliczWiek()
        {
            return 2019 - rokUrodzenia;
        }
    }
}
