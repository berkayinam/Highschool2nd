using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_İstenilenAdetteKolonluSayısalLoto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            string cvp;
            for ( ;cvp!="h" ; )
            {
                Console.Write("Kolon Sayısını Girin : ");
                int kolonSayısı = Convert.ToInt32(Console.ReadLine());

                Random rnd = new Random();
                for (int i = 1; i <= kolonSayısı; i++)
                {
                    Console.Write(i + ". Kolon : ");
                    for (int j = 0; j < 6; j++)
                    {
                        Console.Write(rnd.Next(1, 50) + "     ");
                    }
                    Console.WriteLine();
                }
                Console.Write("Devam Etmek İstiyomusunuz?(h/E)");
                cvp = Console.ReadLine().ToLower(); ;
            }
            Console.ReadLine();
        }
    }
}
