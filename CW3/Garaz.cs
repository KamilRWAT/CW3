using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW3
{
    public class Garaz
    {
        public string Nazwa { get; set; }
        public int Szerokosc { get; set; }
        public int Wysokosc { get; set; }
        public int Dlugosc { get; set; }
        //public int MyProperty { get; set; }
       
        public Samochod [] Pojazdy { get; set; }
        public Garaz()
        {
            this.Nazwa = "Głowny Garaż";
            this.Dlugosc = 100;
            this.Szerokosc = 100;
            this.Wysokosc = 2;
        }

        public int ObjetoscGarazu()
        {
            //int objetosc = this.Dlugosc * this.Szerokosc * this.Wysokosc;
            return this.Dlugosc*this.Szerokosc*this.Wysokosc;

            //return objetosc;
        }

        public static int ObjetoscGarazu2(int wysokosc, int szerokosc, int dlugosc)
        {
            return dlugosc * szerokosc * wysokosc;
        }

        public static int ObjetoscGarazu2(int szerokosc, int dlugosc = 10)
        {
            int wysokosc = 2;
            return dlugosc * szerokosc * wysokosc;
        }
        //public static int ObjetoscGarazu2(int szerokosc)
        //{
        //    int wysokosc = 2;
        //    int dlugosc = 15;
        //    return dlugosc * szerokosc * wysokosc;
        //}
    }
}
