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
        public int Wyoskosc { get; set; }
        public int Dlugosc { get; set; }
        public Samochod [] Pojazdy { get; set; }
        public Garaz()
        {
            this.Nazwa = "Głowny Garaż";
            this.Dlugosc = 100;
            this.Szerokosc = 100;
            this.Wyoskosc = 2;
        }
    }
}
