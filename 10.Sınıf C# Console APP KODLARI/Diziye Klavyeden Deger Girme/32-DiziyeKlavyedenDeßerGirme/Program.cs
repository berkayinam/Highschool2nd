using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_DiziyeKlavyedenDeğerGirme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            string[] isimler=new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("İsimler dizinin {0}. elemanını Gir : ",i);
                isimler[i] = Console.ReadLine();
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("İsimler dizinin {0}. elemanı : {1}"+i,isimler[i]);
            }
            Console.ReadLine();

        }
    }
}
