using System;
using System.IO;
using System.Threading;

namespace YazLab1_3
{
    public enum MasaDurumu
    {
        Uygun,
        Dolu
    }

    public class Masa
    {
        public int MasaNo { get; private set; }
        public MasaDurumu Durum { get; set; }



        public static List<Masa> masalar = new List<Masa>();
        public Masa(int masaNo)
        {
            MasaNo = masaNo;
            Durum = MasaDurumu.Uygun;

            lock (masalar)
            {
                masalar.Add(this);
            }
        }

        public void MasaDurumunuGuncelle(MasaDurumu yeniDurum)
        {
            Durum = yeniDurum;
        }


        public void MasaOlustur()
        {
            Thread[] threads = null;

            if (int.TryParse("6", out int threadSayisi))
            {
                using (TextWriter writer = new StreamWriter("C:/restoran.txt", true))
                {
                    threads = new Thread[threadSayisi];

                    for (int i = 0; i < threadSayisi; i++)
                    {
                        threads[i] = new Thread(() => ThreadIslevi(writer, i + 1, MasaDurumu.Uygun));
                        threads[i].Start();
                        threads[i].Join();
                    }
                }
            }
        }

        void ThreadIslevi(TextWriter writer, int MasaNo, MasaDurumu masaDurumu)
        {
            Masa masa = new Masa(MasaNo);
            masa.MasaDurumunuGuncelle(masaDurumu);
            lock (writer)
            {
                writer.WriteLine($"Masa {masa.MasaNo} oluşturuldu.");
                //  Thread.Sleep(2000);
            }
        }
    }
}