using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_SayıTahmin
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd=new Random();
            int rstSayı = rnd.Next(1,101);
			bool cvp = true;
            for (; cvp ;)
            {
                Console.Write("Sayı Tahmin Et : ");
                int sayı = int.Parse(Console.ReadLine());
                if (sayı>rstSayı)
                {
                    Console.WriteLine("AZALT!!!");
                }
                else if (sayı < rstSayı)
                {
                    Console.WriteLine("ARTIR!!!");
                }else if (sayı==rstSayı)
                {
                    Console.WriteLine("BULDUNUZ TEBRİKLER!!!");
                    break;
                }
            }
            Console.WriteLine("Doğru Sayı : "+rstSayı);
            Console.ReadLine();
        }
    }
}
