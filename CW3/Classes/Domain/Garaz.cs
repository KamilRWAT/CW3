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

        public int ObjetoscGarazu() //zwykła metoda, do użycia wymaga istnienia "garażu"
        {
            //int objetosc = this.Dlugosc * this.Szerokosc * this.Wysokosc;
            return Dlugosc * Szerokosc * Wysokosc;

            //return objetosc;
        }

        public static int ObjetoscGarazuStatic(int wysokosc, int szerokosc, int dlugosc)
        //metoda statyczna, możemy jej użyć, nawet jeśli nie utworzono żadnego "garazu" klasy "Garaz"
        //ale aby z niej skorzystać musimy podać dane wejściowe (argumenty metody)
        {
            return dlugosc * szerokosc * wysokosc;
        }


        //PRZECIĄŻENIE: użyjemy jeszcze raz tej samej nazwy ObjetoscGarazu2, ale z 2 argumentami
        //dzięki temu możemy użyć wywołania metody
        //ObjetoscGarazu2(a,b,c), albo ObjetoscGarazu2(a,b), a nawet ObjetoscGarazu2(a)
        public static int ObjetoscGarazuStatic(int szerokosc, int dlugosc = 10)
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
