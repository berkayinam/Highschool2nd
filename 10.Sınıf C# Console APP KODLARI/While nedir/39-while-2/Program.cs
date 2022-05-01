using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_while_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1’den  50’ye kadar tek sayıları yan yana while döngüsüyle yazdıralım.
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            int sayı = 1;
            while (sayı<=50)
            {
                if (sayı%2==0)
                {
                    Console.Write(sayı+" - ");
                }                
                sayı++;
            }
            Console.ReadLine();
        }
    }
}
