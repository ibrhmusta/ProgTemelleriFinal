using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doğum tarihinizi yıl olarak giriniz:");
            int tarih = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(KacYasindayim(tarih) + " Yaşındasınız");
            Console.ReadKey();
        }
        static int KacYasindayim(int dogumtar)
        {
            int bugun = DateTime.Today.Year;
            return (bugun - dogumtar);
        }
    }
}
