using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hello World! //

            int maças;

            Console.WriteLine("Digite a quantidade de macãs vendidas");
            Console.WriteLine();
            maças = Int32.Parse(Console.ReadLine());

            if (maças >= 12)
            {
                Console.WriteLine("O custo total da compra é: " + (maças * 1));
            }
            else
            {
                Console.WriteLine("O custo total da compra é: " + (maças * 1.30));
            }

            Console.ReadLine();
        }
    }
}
