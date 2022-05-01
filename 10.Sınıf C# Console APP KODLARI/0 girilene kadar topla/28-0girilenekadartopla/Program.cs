using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_0girilenekadartopla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            int sayı,toplam=0;
            do
            {
                Console.Write("Bir sayı gir : ");
                sayı = int.Parse(Console.ReadLine());
                toplam += sayı;
            } while (sayı!=0);
            Console.Write("Toplamxxxx = "+toplam);
            Console.ReadLine();
        }
    }
}
