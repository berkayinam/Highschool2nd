using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_SınırsızHak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Random rnd = new Random();
            int rstSayı = rnd.Next(1, 1001);
            int puan = 100;
        //    for (;;)
        //    {
        //        Console.Write("Sayı Tahmin Et : ");
        //        int sayı = int.Parse(Console.ReadLine());
        //        if (sayı > rstSayı)
        //        {
        //            Console.WriteLine("AZALT!!!");
        //        }
        //        else if (sayı < rstSayı)
        //        {
        //            Console.WriteLine("ARTIR!!!");
        //        }
        //        else if (sayı == rstSayı)
        //        {
        //            Console.WriteLine("BULDUNUZ TEBRİKLER!!! Puanınız : "+puan);
                    
        //            break;
        //        }
        //        puan -= 5;  
        //    }
        //    Console.WriteLine("Doğru Sayı : " + rstSayı);
        //    Console.ReadLine();
            bool bilmeDurumu = false;
            for (;bilmeDurumu==false ; )
            {
                Console.Write("Sayı Tahmin Et : ");
                int sayı = int.Parse(Console.ReadLine());
                if (sayı > rstSayı)
                {
                    Console.WriteLine("AZALT!!!");
                }
                else if (sayı < rstSayı)
                {
                    Console.WriteLine("ARTIR!!!");
                }
                else if (sayı == rstSayı)
                {
                    Console.WriteLine("BULDUNUZ TEBRİKLER!!! ");
                    bilmeDurumu = true;
                }
                Console.WriteLine("Puanınız : "+puan);
                puan -= 5; 
            }
            Console.WriteLine("Doğru Sayı : " + rstSayı);
            Console.ReadLine();
        }
    }
}
