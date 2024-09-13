using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace YazLab1_3
{
    public enum AsciDurumu
    {
        Uygun,
        Mesgul
    }

    public class Asci
    {
        private static SemaphoreSlim semaphore = new SemaphoreSlim(2, 2);
        public int AsciSayisi { get; set; }
        public static object LockObject { get; internal set; } = new object();
        public static List<Asci> ascilar = new List<Asci>();
        public AsciDurumu Durum { get; set; }

        public Asci(int asciSayisi)
        {
            AsciSayisi = asciSayisi;
            Durum = AsciDurumu.Uygun;

            lock (ascilar)
            {
                ascilar.Add(this);
            }
        }

        public async Task SiparisAl(int masaNo)
        {
            if (masaNo <= 6)
            {
                SemaphoreSlim asciSemaphore = new SemaphoreSlim(2, 2);

                lock (LockObject)
                {
                    Durum = AsciDurumu.Mesgul;
                }

                Task[] tasks = new Task[2];

                for (int i = 0; i < tasks.Length; i++)
                {
                    int asciNo = i + 1;
                    tasks[i] = Task.Run(() => ThreadIsleviAsync(asciNo, asciSemaphore));
                }

                await Task.WhenAll(tasks);

                lock (LockObject)
                {
                    Durum = AsciDurumu.Uygun;
                }
            }
        }


        async Task ThreadIsleviAsync(int asciSayisi, SemaphoreSlim asciSemaphore)
        {
            await semaphore.WaitAsync();

            try
            {
                Asci asciOlusturulan = new Asci(asciSayisi);

                lock (LockObject)
                {

                    if (!ascilar.Contains(asciOlusturulan))
                    {
                        ascilar.Add(asciOlusturulan);
                    }
                }


                await Task.Delay(1000);
            }
            finally
            {
                semaphore.Release();
            }
        }
    }



}