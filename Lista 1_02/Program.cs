using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hello World //

            int A, B, C;
            double D, R, S;

            Console.WriteLine("Digite 1 valor para A");
            Console.WriteLine();
            A = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite 1 valor para B");
            Console.WriteLine();
            B = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite 1 valor para C");
            Console.WriteLine();
            C = Int32.Parse(Console.ReadLine());

            R = Math.Pow((A + B), 2);
            S = Math.Pow((B + C), 2);

            D = (R + S) / 2;

            Console.WriteLine("O resultado é: " + D);

            Console.ReadLine();
        }
    }
}
