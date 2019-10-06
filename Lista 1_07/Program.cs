using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hello World //

            double satual, nsalario, preajuste;

            Console.WriteLine("Digite o salário atual");
            Console.WriteLine();
            satual = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o percentual de reajuste");
            Console.WriteLine();
            preajuste = Double.Parse(Console.ReadLine());

            nsalario = (satual + (preajuste * satual));

            Console.WriteLine("O novo salário é: " + nsalario);

            Console.ReadLine();
        }
    }
}
