
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazLab1_3
{
    public partial class GarsonForm : Form
    {
        Musteri musteri = new Musteri(9);
        public GarsonForm()
        {
            InitializeComponent();

        }
        int i = 1;
        int j = 1;
        int m = 1;
        private void button1_Click(object sender, EventArgs e)
        {

            for (; i <= musteri.MusteriSayisi; i++)
            {
                if (Masa.masalar[j].Durum == MasaDurumu.Uygun && Masa.masalar[j].MasaNo == j)
                {
                    // Masa.masalar[j].Durum = MasaDurumu.Dolu;

                    deneme.AppendText($"{i}. müşteri oturdu. {j}. masa dolu." + Environment.NewLine);

                    if (j == 6)
                    {
                        break;
                    }
                    j++;
                }
            }
        }
        int k = 7;
        int l = 1;
        private void button2_Click(object sender, EventArgs e)
        {

            for (; k <= musteri.MusteriSayisi; k++)
            {
                if (Masa.masalar[l].Durum == MasaDurumu.Uygun && Masa.masalar[l].MasaNo == l)
                {

                    //  Masa.masalar[j].Durum = MasaDurumu.Dolu;

                    deneme1.AppendText($"{k}. müşteri oturdu. {l}. masa dolu." + Environment.NewLine);

                    if (l == 6)
                    {
                        break;
                    }

                    l++;
                }
            }
        }
        int x = 1;
        private void button3_Click(object sender, EventArgs e)
        {

            for (; x <= 6; x++)
            {
                if (Garson.garsonlar[m].Durum == GarsonDurumu.Uygun && Garson.garsonlar[m].GarsonNo == m)
                {
                    deneme.AppendText($"Garson {m} müşteri {x} siparişini aldı." + Environment.NewLine);

                    if (m == 3)
                    {
                        x++;
                        m = 1;
                        break;
                    }
                    m++;

                }
            }
        }

        int y = 7;
        private void button4_Click(object sender, EventArgs e)
        {
            for (; y<= musteri.MusteriSayisi; y++)
            {
                if (Garson.garsonlar[m].Durum == GarsonDurumu.Uygun && Garson.garsonlar[m].GarsonNo == m)
                {
                    deneme1.AppendText($"Garson {m} müşteri {y} siparişini aldı." + Environment.NewLine);

                    if (m == 3)
                    {

                        m = 1;
                        break;
                    }
                    m++;

                }
            }
        }
    }

}