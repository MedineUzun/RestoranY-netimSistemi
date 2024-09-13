
namespace YazLab1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void buttongarson_Click(object sender, EventArgs e)
        {
            GarsonForm garson = new GarsonForm();
            garson.Show();
        }

        private void buttonasci_Click(object sender, EventArgs e)
        {
            AsciForm asci = new AsciForm();
            asci.Show();
        }

        private void buttonkasa_Click(object sender, EventArgs e)
        {
            KasaForm kasa = new KasaForm();
            kasa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri(9);

            musteri.MusteriOlustur();
            musteri.MusteriMasayaGec(1);
            musteri.MusteriGarson(1);
            musteri.MusteriSiparis(0);

            musteri.MusteriMasayaGec(7);
            musteri.MusteriGarson(4);
            musteri.MusteriSiparis(3);
            musteri.MusteriGarson(7);
            musteri.MusteriSiparis(6);
        }
    }


}