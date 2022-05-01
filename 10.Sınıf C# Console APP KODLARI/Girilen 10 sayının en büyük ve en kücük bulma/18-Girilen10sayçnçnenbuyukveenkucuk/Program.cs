using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Girilen10sayınınenbuyukveenkucuk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            int enBuyuk=0, enKucuk=0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i+". sayıyı Girin : ");
                int sayı = int.Parse(Console.ReadLine());
                if (i==1)
                {
                    enBuyuk = sayı;
                    enKucuk = sayı;
                }
                else
                {
                    if (sayı>enBuyuk)
                    {
                        enBuyuk = sayı;
                    }
                    if (sayı<enKucuk)
                    {
                        enKucuk=sayı;
                    }	
                }
            }
            Console.Write("{0} enbuyuk sayı,{1} enküçük sayı",enBuyuk,enKucuk);
            Console.ReadLine();
        }
    }
}
