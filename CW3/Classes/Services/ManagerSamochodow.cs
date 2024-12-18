using CW3.Classes.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW3.Classes.Services
{
    public class ManagerSamochodow
    {

        public double IlePrzejechal (double paliwo, Samochod samochod)
        {
            double kilometry = 0;

            if (paliwo > samochod.PojemnoscBaku)
            {
                MessageBox.Show($"Maksymalna ilość paliwa to {samochod.PojemnoscBaku}");
                kilometry = (samochod.PojemnoscBaku/samochod.Spalanie)*100;
            }
            else
            {
                kilometry = (paliwo / samochod.Spalanie)*100;
            }

            return kilometry;
        }

        public void ZmianaLicznika (double paliwo, Samochod samochod)
        {
            samochod.Licznik += IlePrzejechal(paliwo,samochod);
        }

        public void ZmianaLicznika(double paliwo, List<Samochod> samochod)
        {
            foreach (Samochod auto in samochod)
            {
                auto.Licznik += IlePrzejechal(paliwo, auto);
            }
        }
    }
}
