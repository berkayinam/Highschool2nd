using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_indexof
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            int[] dizi = new int[4];
            dizi[0] = 5;
            dizi[1] = 6;
            dizi[2] = 7;
            dizi[3] = 8;
            int[] mizi = new int[4];
            mizi[0] = 9;
            mizi[1] = 10;
            mizi[2] = 11;
            mizi[3] = 12;
            int aramaSonucu;
			Console.Write("hangi sayıyı aramak istiyorsunuz: ");
			int kullanici = Convert.ToInt32(Console.ReadLine());
			if (kullanici>8)
			{
				aramaSonucu = Array.IndexOf(mizi, kullanici);
				Console.Write(aramaSonucu);
			}
			else
			{
				aramaSonucu = Array.IndexOf(dizi, kullanici);
				Console.Write(aramaSonucu);
			}
            Console.ReadLine();
        }
    }
}
