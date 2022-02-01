using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviZadPonavljanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Upišite stranice trokuta(x, y, z): ");
            Console.WriteLine("Upišite x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upišite y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upišite z: ");
            z = Convert.ToInt32(Console.ReadLine());
            
            if(x>0 && y>0 && z>0)
            {
                if ((x * x) + (y * y) == (z * z))
                {
                    Console.WriteLine("Trokut je pravokutan");
                }
                else
                {
                    Console.WriteLine("trokut nije pravokutan");
                }

            }






            Console.ReadKey();

        }
    }
}
