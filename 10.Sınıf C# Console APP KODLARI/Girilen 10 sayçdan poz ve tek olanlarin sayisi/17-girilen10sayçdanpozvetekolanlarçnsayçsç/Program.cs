using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_girilen10sayıdanpozvetekolanlarınsayısı
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            int adet = 0;
            for (int i = 1; i <=10; i++)
            {
                Console.Write(i+".sayıyı giriniz : ");
                int sayı = Int32.Parse(Console.ReadLine());
                if (sayı>=0 && sayı%2!=0)
                {
                    adet++;
                }
            }
            Console.Write("pozitif ve tek sayıların adeti = "+adet);
            Console.ReadLine();
            
            {

            }
        }
    }
}
