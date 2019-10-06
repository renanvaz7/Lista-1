using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hello World //

            int idade;

            Console.WriteLine("Digite sua idade");
            Console.WriteLine();
            idade = Int32.Parse(Console.ReadLine());

            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("Categoria Infantil A");
            }
            else if (idade >= 8 && idade <= 10)
            {
                Console.WriteLine("Categoria Infantil B");
            }
            else if (idade >= 11 && idade <= 13)
            {
                Console.WriteLine("Categoria Juvenil A");
            }
            else if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("Categoria Juvenil B");
            }
            else
            {
                Console.WriteLine("Categoria Adulto");
            }
            Console.ReadLine();
        }
    }
}
