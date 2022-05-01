using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_DiziyeSayıGirişi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            int[] sayıDizisi=new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i+1)+". sayıyı girin : ");
                sayıDizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            for (int i = 0; i < 10; i++)
            {
                toplam += sayıDizisi[i];
            }
            double ort = toplam / 10d;
            Console.Write("Girilen Sayıların Toplamı = {1} ,ortalaması = {0}",ort,toplam);
            Console.ReadLine();
        }
    }
}
