using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_HesapMakinesi
{
    class Program
    {
        static int topla(int s1,int s2)
        {
            int toplam = s1 + s2;
            return toplam;
        }
        static int çıkar(int s1, int s2)
        {
            int fark = s1 - s2;
            return fark;
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Write("Sayı1 gir : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sayı2 gir : ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("işlem seç( + yada - )");
            string islem = Console.ReadLine();
            int sonuç = 0;
            if (islem=="+")
            {
                sonuç = topla(x1, x2);
            }
            else if (islem=="-")
            {
                sonuç = çıkar(x1, x2);
            }
            Console.Write("Sonuç : "+sonuç);
            Console.ReadLine();
         
        }
    }
}
