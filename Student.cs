using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw4
{
    class Student: Osoba
    {
        public int rok, numerGrupy, numerAlbumu;

        public Student(string imie, string nazwisko, int rokUrodzenia, string miejsceZamieszkania, int rok, int numerGrupy, int numerAlbumu)
            :base(imie, nazwisko, rokUrodzenia, miejsceZamieszkania)
        {
            this.rok = rok;
            this.numerGrupy = numerGrupy;
            this.numerAlbumu = numerAlbumu;
        }

        public void WypiszInfo()
        {
            Console.WriteLine($"Imie: {imie}, Nazwisko: {nazwisko}, rok urodzenia: {rokUrodzenia}, miejsce zamieszkania: {miejsceZamieszkania} rok: {rok}, numer grupy:{numerGrupy}, numer albumu: " +
                $"{numerAlbumu}");
        }
    }
}
