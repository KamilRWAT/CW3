using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW3.Classes.Domain
{
    public class Garaz
    {
        public string Nazwa { get; set; }
        public int Szerokosc { get; set; }
        public int Wysokosc { get; set; }
        public int Dlugosc { get; set; }
        //public int MyProperty { get; set; }

        public Samochod[] Pojazdy { get; set; }
        public Garaz()
        {
            Nazwa = "Głowny Garaż";
            Dlugosc = 100;
            Szerokosc = 100;
            Wysokosc = 2;
        }
    }
}
