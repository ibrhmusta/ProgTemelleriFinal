using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int say1, say2, sonuc, sayac;
            Console.WriteLine("İlk sayıyı giriniz :");
            say1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz :");
            say2 = Convert.ToInt32(Console.ReadLine());
            sonuc = say1;

            for (sayac = 0; say2 <= sonuc; sayac++)
            {
                sonuc = sonuc - say2;
            }
            Console.WriteLine("Bölen: " + say1);
            Console.WriteLine("Bölüm: " + sayac);
            Console.WriteLine("Kalan: " + sonuc);
            Console.ReadKey();
        }
    }
}
