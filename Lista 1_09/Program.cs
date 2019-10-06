using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_09
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hello World //

            double sfixo, comissao, vtvendas, ncvendidos, sfinal, pvvendas;

            Console.WriteLine("Digite o salário fixo");
            Console.WriteLine();
            sfixo = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de carros vendidos");
            Console.WriteLine();
            ncvendidos = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor total das vendas");
            Console.WriteLine();
            vtvendas = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a comissão");
            Console.WriteLine();
            comissao = Double.Parse(Console.ReadLine());


            pvvendas = (5 / 100 * vtvendas);
            sfinal = (sfixo + (comissao * ncvendidos) + pvvendas);

            Console.WriteLine("O salário final é: " + sfinal);
            Console.ReadLine();
        }
    }
}
