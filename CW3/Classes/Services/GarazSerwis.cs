using CW3.Classes.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW3.Classes.Services
{
    public class GarazSerwis
    {
        private Garaz _garaz;

        //ctor
        public GarazSerwis()
        {
        }

        public int ObjetoscGarazu(Garaz garaz) //zwykła metoda, do użycia wymaga istnienia "garażu"
        {
            _garaz = garaz;
            //int objetosc = this.Dlugosc * this.Szerokosc * this.Wysokosc;
            return _garaz.Dlugosc * _garaz.Szerokosc * _garaz.Wysokosc;

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
