using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazLab1_3
{ public enum GarsonDurumu
        {
            Uygun,
            Mesgul
        }
    internal class Garson
    {
       
            public GarsonDurumu Durum { get; set; }
            public int GarsonNo { get; set; }
            public static object LockObject { get; internal set; } = new object();

            public static List<Garson> garsonlar = new List<Garson>();
      
        public Garson(int garsonno)
        {
            GarsonNo = garsonno;
            Durum = GarsonDurumu.Uygun;

            lock (garsonlar)
            {
                garsonlar.Add(this);
            }

        }

        public void GarsonOlustur()
        {
            Thread[] threads = null;

            if (int.TryParse("3", out int threadSayisi))
            {
                using (TextWriter writer = new StreamWriter("C:/restoran.txt", true))
                {
                    threads = new Thread[threadSayisi];

                    for (int i = 0; i < threadSayisi; i++)
                    {
                        threads[i] = new Thread(() => ThreadIslevi(writer, i+1, GarsonDurumu.Uygun));
                        threads[i].Start();
                        threads[i].Join(); 
                    }
                }
            }
        }

        void ThreadIslevi(TextWriter writer, int garsonNo,GarsonDurumu garsonDurumu)
        {
            Garson garson = new Garson(garsonNo);
            garson.Durum = GarsonDurumu.Uygun;
            lock (writer)
            {
                writer.WriteLine($"Garson {garsonNo} oluşturuldu.");
                //  Thread.Sleep(2000);
            }
        }

    }
}