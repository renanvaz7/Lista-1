using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hello World //

            int a, b, c;

            Console.WriteLine("Digite 1 valor para a");
            Console.WriteLine();
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite 1 valor para b");
            Console.WriteLine();
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite 1 valor para c");
            Console.WriteLine();
            c = Int32.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(a + " é o maior valor.");
            }
            else if (b > c)
            {
                Console.WriteLine(b + " é o maior valor.");
            }
            else
            {
                Console.WriteLine(c + " é o maior valor.");
            }
            Console.ReadLine();
        }
    }
}
