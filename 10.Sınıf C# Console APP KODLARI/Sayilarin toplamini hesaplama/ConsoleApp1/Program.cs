using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci sayıyı giriniz : ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz : ");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üçüncü sayıyı giriniz : ");
            int s3 = Convert.ToInt32(Console.ReadLine());
            int top = s1+s2+s3;
            int ort = top / 3;
            Console.WriteLine("Sayıların Toplamı = " + top);
            Console.WriteLine("Sayıların Ortalaması = " + ort);
            Console.ReadKey();
        }
    }
}
