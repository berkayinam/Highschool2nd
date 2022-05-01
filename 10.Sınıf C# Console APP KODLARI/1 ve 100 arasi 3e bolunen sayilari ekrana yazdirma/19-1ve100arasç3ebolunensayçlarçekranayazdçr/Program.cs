using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_1ve100arası3ebolunensayılarıekranayazdır
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            for (int i = 1; i <= 100; i++)
            {
                if (i%3==0)
                {
                    Console.Write(i + "-");
                }
                
            }
            Console.ReadLine();
        }
    }
}
