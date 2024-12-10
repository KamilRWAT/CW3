namespace CW3
{
    public partial class Form1 : Form
    {
        Garaz garaz;
        public Form1()
        {
            InitializeComponent();

            garaz = new Garaz();
            List<Samochod> samochody = new List<Samochod>();
            Samochod samochod = new Samochod
            {
                Marka = "Opel",
                Model = "Astra",
                Kolor = "Czerwony",
                Licznik = 100000,
                PojemnoscBaku = 25,
                Spalanie = 8
            };
            samochody.Add(samochod);
            Samochod samochod2 = new Samochod
            {
                Marka = "Opel",
                Model = "Insignia",
                Kolor = "Zielony",
                Licznik = 50000,
                PojemnoscBaku = 25,
                Spalanie = 10
            };
            samochody.Add(samochod2);
            Samochod samochod3 = new Samochod
            {
                Marka = "Mercedes",
                Model = "C",
                Kolor = "Czerwony",
                Licznik = 100000,
                PojemnoscBaku = 25,
                Spalanie = 12
            };
            samochody.Add(samochod3);

            garaz.Pojazdy = samochody.ToArray();
        }
    }
}
