using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_DiziTanımlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            //veritipi[] diziadı={"veri","veri","veri","veri"};
            string[] ogrenciler = { "semih", "berivan", "yunus", "tarık" };
            //dizielemanlarına erişim için diziadı[indexno];
            Console.WriteLine(ogrenciler[0]);
            Console.WriteLine(ogrenciler[1]);
            Console.WriteLine(ogrenciler[2]);
            Console.WriteLine(ogrenciler[3]);
           
            Console.ReadLine();
        }
    }
}
