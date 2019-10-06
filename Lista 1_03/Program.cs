using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hello World //

            double cfabrica, pdistribuidora, imposto, vfinal;

            Console.WriteLine("Digite o custo de fábrica do carro");
            Console.WriteLine();
            cfabrica = double.Parse(Console.ReadLine());

            pdistribuidora = (cfabrica * 28 / 100);
            imposto = (cfabrica * 45 / 100);

            vfinal = (cfabrica + pdistribuidora + imposto);

            Console.WriteLine("O valor final do carro é: " + vfinal);
            Console.ReadLine();
        }
    }
}
