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

        private void btnWyswietl_Click(object sender, EventArgs e)
        {
            //dgvPojazdy.DataSource = cbGaraze.SelectedItem;
            //Nie wyœwietla informacji poniewa¿ wskazujemy 1 konkretny obiekt
            //a combobox nie wie któr¹ w³aœciowœæ ma wybraæ
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Garaz> listaGarazy = new List<Garaz>();
            listaGarazy.Add(garaz);
            cbGaraze.DataSource = listaGarazy;
            cbGaraze.DisplayMember = "Nazwa";
            cbGaraze.ValueMember = "Nazwa";
        }

        private void cbGaraze_SelectedIndexChanged(object sender, EventArgs e)
        {
            Garaz wybranyGaraz = (Garaz)cbGaraze.SelectedItem;
            dgvPojazdy.DataSource = wybranyGaraz.Pojazdy;
        }
    }
}
