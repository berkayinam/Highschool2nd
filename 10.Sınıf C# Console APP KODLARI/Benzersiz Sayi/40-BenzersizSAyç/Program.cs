using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_BenzersizSAyı
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();           
            Random rnd = new Random();
            int[] dizi = new int[6];
            int rst;
            for (int i = 0; i <6; i++) 
            {
                dizi[i] = -1; 
            }
            for (int i = 0; i < 6; i++)
            {
                do
                {
                   rst = rnd.Next(0, 6);
                } while (Array.IndexOf(dizi,rst)>-1);               
                dizi[i] = rst;
            }
           // Array.Sort(dizi);
            foreach (var ethem in dizi)
            {
                Console.Write(ethem + ", "); 
            }
            Console.ReadKey();
           
        }
    }
}
