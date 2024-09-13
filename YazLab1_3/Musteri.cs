using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace YazLab1_3
{
    internal class Musteri
    {
        private static Semaphore garsonSemaphore;
        private static Semaphore asciSemaphore;
        private static object LockObject = new object();



        public int KacMusteri()
        {
            int sayi = MusteriSayisi - 7;

            return sayi;
        }
        public int MusteriSayisi { get; set; }

        public Musteri(int musteriSayisi)
        {
            MusteriSayisi = musteriSayisi;
        }

        public void MusteriOlustur()
        {
            Thread[] threads = new Thread[MusteriSayisi];

            using (TextWriter writer = new StreamWriter("C:/restoran.txt", true))
            {
                for (int i = 0; i < MusteriSayisi; i++)
                {
                    threads[i] = new Thread(() => ThreadIslevi(writer, i + 1));
                    threads[i].Start();
                    threads[i].Join();
                }
            }
        }

        void ThreadIslevi(TextWriter writer, int threadID)
        {
            lock (LockObject)
            {
                writer.WriteLine($"Musteri {threadID} sırada bekliyor.");
            }
        }


        List<Masa> masalar = new List<Masa>();
        int j = 1;
        public void MusteriMasayaGec(int i)
        {
            Thread[] threads = new Thread[MusteriSayisi + 1];

            using (TextWriter writer = new StreamWriter("C:/restoran.txt", true))
            {


                threads = new Thread[MusteriSayisi + 1];

                for (; i <= MusteriSayisi; i++)
                {


                    if (Masa.masalar[j].Durum == MasaDurumu.Uygun && Masa.masalar[j].MasaNo == j)
                    {

                        Masa.masalar[j].Durum = MasaDurumu.Dolu;

                        threads[i] = new Thread(() => ThreadIslevi2(writer, i, j));
                        threads[i].Start();
                        threads[i].Join();
                       
                        if (j == 6)
                        {
                            //Thread.Sleep(2000);
                            j = 1;

                        }
                        else
                        {
                            j++;
                        }

                    }
                }
            }
        }

        void ThreadIslevi2(TextWriter writer, int threadID, int masaNo)
        {
            lock (LockObject)
            {
                writer.WriteLine($"Musteri {threadID} masa {masaNo} oturdu.");
            }
        }

        public void MusteriGarson(int i)
        {
            Thread[] threads = new Thread[MusteriSayisi + 1];
            int j = 1;
            using (TextWriter writer = new StreamWriter("C:/restoran.txt", true))
            {
                threads = new Thread[MusteriSayisi + 1];
                for (; i < MusteriSayisi + 1; i++)
                {
                    if (Garson.garsonlar[j].Durum == GarsonDurumu.Uygun && Garson.garsonlar[j].GarsonNo == j)
                    {
                        Garson.garsonlar[j].Durum = GarsonDurumu.Mesgul;
                        threads[i] = new Thread(() => ThreadIslevi3(writer, i, j));
                        threads[i].Start();
                        threads[i].Join();

                        if (j == 3)
                        {
                            j = 1;
                        }
                        else
                        {
                            j++;
                        }
                    }
                }
            }
        }

        void ThreadIslevi3(TextWriter writer, int threadID, int garsonNo)
        {
            lock (LockObject)
            {
                writer.WriteLine($"Garson {garsonNo} Musteri {threadID} siparişini aldı.");
            }
        }

        public void MusteriSiparis(int masa)
        {
            if (int.TryParse(MusteriSayisi.ToString(), out int threadSayisi))
            {
                garsonSemaphore = new Semaphore(3, 3);
                asciSemaphore = new Semaphore(2, 2);

                Thread[] threads = new Thread[threadSayisi];
                int j = 1;

                using (TextWriter yazici = new StreamWriter("C:/restoran.txt", true))
                {
                    for (int i = 0; i < threadSayisi; i++)
                    {
                        if (Garson.garsonlar[j].Durum == GarsonDurumu.Mesgul)
                        {
                            Garson.garsonlar[j].Durum = GarsonDurumu.Uygun;

                            int garsonNo = ((i / 2) % 3) + 1;
                            int asciNo = (i % 2) + 1;

                            masa = (masa % 6) + 1;

                            Asci asci = new Asci(asciNo);
                            asci.SiparisAl(masa);




                            threads[i] = new Thread(() => ThreadIslevi4(yazici, masa, garsonNo, asciNo));
                            threads[i].Start();
                            threads[i].Join();

                            if (j == 3)
                            {
                                j = 1;
                            }
                            else
                            {
                                j++;
                            }
                            Kasa kasa = new Kasa();
                            kasa.OdemeAl(masalar, masa + 1);
                        }
                    }
                }
            }
        }



        static void ThreadIslevi4(TextWriter writer, int masaNo, int garsonNo, int asciNo)
        {
            try
            {
                garsonSemaphore.WaitOne(); 
                asciSemaphore.WaitOne(); 

                lock (LockObject)
                {

                    writer.WriteLine($"Asci {asciNo}  {masaNo} masasinin siparişini hazırlıyor.");

                    // Thread.Sleep(2000);
                    writer.WriteLine($"  {masaNo} ödemesini yaptı.");
                }
            }
            finally
            {
                garsonSemaphore.Release();
                asciSemaphore.Release(); 
            }
        }
    }
}