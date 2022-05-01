using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_diziyeRstSayıAtamak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            int[] bh = new int[10];
            Random rnd = new Random();
	
            for (int i = 0; i < 10; i++)
            {
                bh[i] = rnd.Next(1, 50);
            }
			Array.Sort(bh);
			Array.Reverse(bh);
			for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(bh[j]);
            }
            Console.Write("bh dizisinin 5. elemanı: {0}, 6. elemanı: {1}, 7. elemanı: {2}", bh[5], bh[6], bh[7]);
            Console.ReadLine();
            
        }
    }
}
