using System;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            int aylikmaas, toplammaas, maxmaas, maxindex;
            double deger, yil;
            int[] maaslar = new int[36];
            for (int i = 1; i <= 36; i++)
            {
                aylikmaas = rastgele.Next(100, 200);
                maaslar[i - 1] = aylikmaas;
                Console.WriteLine(maaslar[i - 1] + "TL");
            }
            toplammaas = maaslar.Sum();
            Console.WriteLine("Toplam maaş: " + toplammaas + "TL");
            maxmaas = maaslar.Max();
            maxindex = maaslar.ToList().IndexOf(maxmaas);
            deger = (maxindex / 12);
            yil = (Math.Floor(deger)) + 1;
            Console.WriteLine("En yüksek maaş aldığı ay:" + (maxindex + 1));
            Console.WriteLine("En yüksek maaş aldığı yıl:" + yil);
            Console.ReadKey();
        }
    }
}
