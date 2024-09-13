using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;

namespace YazLab1_3
{
    public class Kasa
    {
        private static object LockObject = new object();

        public void OdemeAl(List<Masa> masalar, int j)
        {
            j = 1;

            lock (LockObject)
            {
                if (masalar.Count > j && j >= 0)
                {
                    while (masalar[j].Durum == MasaDurumu.Dolu)
                    {
                        Masa.masalar[j].Durum = MasaDurumu.Uygun;

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
                else
                {
                     Console.WriteLine("Geçersiz indeks");
                }
            }
        }
    }
}