using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hello World //

            double d, x1, x2, y1, y2;

            Console.WriteLine("Digite um valor para x");
            Console.WriteLine();
            x1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para y");
            Console.WriteLine();
            y1 = Double.Parse(Console.ReadLine());

            x2 = ((x1 * 2) - (x1 * 1));

            y2 = ((y1 * 2) - (y1 * 1));

            d = Math.Sqrt(Math.Pow(((x1 * 2) - (x1 * 1)) - ((y1 * 2) - (y1 * 1)), 2));

            Console.WriteLine("A distância entre eles é: " + d);
            Console.ReadLine();
        }
    }
}
