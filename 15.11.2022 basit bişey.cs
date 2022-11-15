using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
          
            byte ay = Convert.ToByte(Console.ReadLine());
            
            if (ay == 1)
                Console.WriteLine("ocak");
            else if (ay == 2)
                Console.WriteLine("şubat");
            else if (ay == 3)
                Console.WriteLine("mart");
            else if (ay == 4)
                Console.WriteLine("nisan");
            else if (ay == 5)
                Console.WriteLine("mayıs");
            else if (ay == 6)
                Console.WriteLine("haziran");
            else if (ay == 7)
                Console.WriteLine("temmuz");
            else if (ay == 8)
                Console.WriteLine("ağustos");
            else if (ay == 9)
                Console.WriteLine("eylül");
            else if (ay == 10)
                Console.WriteLine("ekim");
            else if (ay == 11)
                Console.WriteLine("kasım");
            else if (ay == 12)
                Console.WriteLine("aralık");
            else
                Console.WriteLine("1 ile 12 arası sayı gir bakim gardaş");
            Console.WriteLine("neler oluyor hayatta");

            Console.ReadKey();
            
        }
    }
}
