using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_10LokonluSayısalLoto
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i+". Kolon : ");
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(rnd.Next(1, 50) + "     ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
