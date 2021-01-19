using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vize notu giriniz:");
            int vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final notu giriniz:");
            int final = Convert.ToInt32(Console.ReadLine());
            int not = NotHesapla(vize, final);
            Console.WriteLine("Ders notunuz: " + not);
            if (not >= 50)
            {
                Console.WriteLine("Geçti");
            }
            else
            {
                Console.WriteLine("Kaldı");
            }
            Console.ReadKey();
        }
        static int NotHesapla(int vize, int final)
        {
            return (((vize * 40) / 100) + ((final * 60) / 100));
        }
    }
}
