using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hello World //

            double teleitores, vbrancos, vnulos, vvalidos, pbrancos, pnulos, pvalidos;

            Console.WriteLine("Digite o número total de eleitores");
            Console.WriteLine();
            teleitores = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de votos brancos");
            Console.WriteLine();
            vbrancos = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de votos nulos");
            Console.WriteLine();
            vnulos = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de votos válidos");
            Console.WriteLine();
            vvalidos = Double.Parse(Console.ReadLine());

            pbrancos = (vbrancos * 100 / teleitores);

            Console.WriteLine("O percentual de votos brancos é: " + pbrancos + "%");
            Console.WriteLine();

            pnulos = (vnulos * 100 / teleitores);

            Console.WriteLine("O percentual de votos nulos é: " + pnulos + "%");
            Console.WriteLine();

            pvalidos = (vvalidos * 100 / teleitores);

            Console.WriteLine("O percentual de votos válidos é: " + pvalidos + "%");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
