using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw5_cd
{
    class Program
    {
        static void Main(string[] args)
        {
            Test obiekt1 = new Test();
            Test obiekt2 = new Test();
            Test obiekt3 = new Test();

            obiekt1.liczba = 255;
            obiekt1.poleTestowe.slowo = "słowo";
            obiekt2 = obiekt1;
            obiekt3 = obiekt1.GlebokaKopia();
            obiekt1.liczba = 347;
            obiekt1.poleTestowe.slowo = "kaczka";

            Console.WriteLine($"obiekt1: {obiekt1.liczba}, obiekt2: {obiekt2.liczba}, obiekt3: {obiekt3.liczba}, słowo: {obiekt1.poleTestowe.slowo}");

            Console.ReadKey();
        }
    }
}
