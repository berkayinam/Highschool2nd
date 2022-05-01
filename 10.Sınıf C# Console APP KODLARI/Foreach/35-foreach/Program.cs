using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            int[] sayıDizisi = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i + 1) + ". sayıyı girin : ");
                sayıDizisi[i] = int.Parse(Console.ReadLine());
            }
			Array.Sort(sayıDizisi);
			Array.Reverse(sayıDizisi);
			foreach (int item in sayıDizisi)
			{
				Console.WriteLine(item);
			}
            Console.ReadLine();

        }
    }
}
