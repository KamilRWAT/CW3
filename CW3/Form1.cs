using CW3.Classes.Domain;
using CW3.Classes.Services;

namespace CW3
{
    public partial class Form1 : Form
    {
        Garaz garaz;
        GarazSerwis mojGarazSerwis;
        ManagerSamochodow mojManagerSamochodow;
        public Form1()
        {
            InitializeComponent();

            garaz = new Garaz();
            mojGarazSerwis = new GarazSerwis();
            mojManagerSamochodow = new ManagerSamochodow();

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
            //Nie wy�wietla informacji poniewa� wskazujemy 1 konkretny obiekt
            //a combobox nie wie kt�r� w�a�ciow�� ma wybra�
            //MessageBox.Show(Convert.ToString(garaz.ObjetoscGarazu()));

            //MessageBox.Show("Objetosc rzeczywista garazu " + mojGarazSerwis.ObjetoscGarazu(garaz) + "\r\n"
            //    + "Objetosc hipotetyczna " + GarazSerwis.ObjetoscGarazuStatic(10, 10, 10) +"\r\n"
            //    + "Objetosc hipotetyczna (2 argumenty) " + GarazSerwis.ObjetoscGarazuStatic(10, 10) +"\r\n"
            //    + "Objetosc hipotetyczna (1 argument) " + GarazSerwis.ObjetoscGarazuStatic(10));
            try
            {
                List<Samochod> wybraneSamochody = new List<Samochod>();
                foreach(DataGridViewRow row in dgvPojazdy.SelectedRows)
                {
                    wybraneSamochody.Add((Samochod)row.DataBoundItem);
                }

                //DataGridViewRow row = dgvPojazdy.SelectedRows[0];
                //Samochod samochod = (Samochod)row.DataBoundItem;
                mojManagerSamochodow.ZmianaLicznika(Convert.ToDouble(txtPaliwo.Text), wybraneSamochody);
            }
            catch (Exception)
            {
                MessageBox.Show("Paliwo musi by� liczb�");
            }


            dgvPojazdy.Refresh();
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
