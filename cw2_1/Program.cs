using System;

namespace cw2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string carName = "Mój samochód";
            Console.WriteLine(carName);
            Car car1 = new Car("Ford", 2005);
            Car car2 = new Car("Audi", 2012);
            car2.PokazCar();
            /* car1 = car2;
             car2.PokazCar(); */
            Console.WriteLine(car2.ObliczKosztPrzejazdu(250, 4.13));
            Car.opiszTyp("Ford", 2005);

            Console.ReadKey();
        }
        class Car
        {
            private string marka;
            private int rok;
            private string model;
            private int iloscDrzwi;
            private double pojemnoscSilnika;
            public double srednieSpalanie;
            public Car(string m, int r)
            {
                marka = m;
                rok = r;
            }
            public void PokazCar()
            {
                Console.WriteLine("{0, -15} {1, 10}", marka, rok);
            }
            private double ObliczSpalanie(double dlugoscTrasy)
            {
                double spalanie = 0;             
                Console.WriteLine("Podaj srednie spalanie:");
                srednieSpalanie = double.Parse(Console.ReadLine());
                spalanie = srednieSpalanie * dlugoscTrasy;
                return spalanie; 
            }
            public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
            {
                double kosztPrzejazdu = 0;
                kosztPrzejazdu = dlugoscTrasy * cenaPaliwa; 
                return kosztPrzejazdu;
            }
            public static void opiszTyp(string marka, int rok)
            {
                Console.WriteLine("{0} {1}", marka, rok);
            }
        }
    }
}
