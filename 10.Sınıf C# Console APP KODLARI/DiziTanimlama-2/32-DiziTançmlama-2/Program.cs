using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_DiziTanımlama_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            string[] isimler=new string[5];
            isimler[0]="semih";
            isimler[1] = "berivan";
            isimler[2] = "yunus";
            isimler[3] = "tarık";
                isimler[4]="emre";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(isimler[i]);
            }
            Console.ReadLine();
        }
    }
}
