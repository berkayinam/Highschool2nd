using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_SeçmeliKolon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
           
            //Console.Write("Kaç Kolon Oynamayı İstiyorsun : ");
            //int kolonSayısı = Convert.ToInt32(Console.ReadLine());
            //if (kolonSayısı<1)
            //{
            //    Console.WriteLine("1 den küçük kolon sayısı olmaz");
            //    Console.Write("Kaç Kolon Oynamayı İstiyorsun : ");
            //    kolonSayısı = Convert.ToInt32(Console.ReadLine());
            //}
            //else if (kolonSayısı>10)
            //{
            //    Console.WriteLine("10 dan büyük kolon sayısı olamaz");
            //    Console.Write("Kaç Kolon Oynamayı İstiyorsun : ");
            //    kolonSayısı = Convert.ToInt32(Console.ReadLine());
            //}
            string cevap="E";
            for (; cevap=="E"||cevap=="e"; )
            {
                bool basarılıKolonSayısıGirisi = false;
                int kolonSayısı = 0;
                for (; basarılıKolonSayısıGirisi == false; )
                {
                    Console.Write("Kaç Kolon Oynamayı İstiyorsun : ");
                    kolonSayısı = Convert.ToInt32(Console.ReadLine());
                    if (kolonSayısı < 1)
                    {
                        Console.WriteLine("1 den küçük kolon sayısı olmaz");
                    }
                    else if (kolonSayısı > 10)
                    {
                        Console.WriteLine("10 dan büyük kolon sayısı olamaz");
                    }
                    else
                    {
                        basarılıKolonSayısıGirisi = true;
                    }
                }
                Random rnd = new Random();
                for (int i = 1; i <= kolonSayısı; i++)
                {
                    Console.WriteLine(i + ". Kolon Tahminleri");

                    for (int j = 0; j < 6; j++)
                    {
                        Console.Write(rnd.Next(1, 50) + "  ");
                    }
                    Console.WriteLine();
                }
                Console.Write("Tekrar tahminde bulunmak istiyormusunuz (e/h) : ");
                cevap = Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
