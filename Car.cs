using System;
using System.Collections.Generic;
using System.Text;

namespace cw3
{
    class Car
    {
        private double pojemnoscSilnika;
        private string marka;
        static int iloscKol;

        private Car(double pojemnoscSilnika, string marka)
        {
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.marka = marka;
        }

        public static Car Create(double pojemnoscSilnika, string marka)
        {
            return new Car(pojemnoscSilnika, marka);
        }

        static Car()
        {
            iloscKol = 4;
        }
        
        ~Car()
        {
            MessageBox.Show("Zwalniam pamięć");
        } 

    }
}
