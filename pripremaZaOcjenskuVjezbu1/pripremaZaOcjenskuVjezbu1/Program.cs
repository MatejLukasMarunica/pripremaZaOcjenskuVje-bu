using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pripremaZaOcjenskuVjezbu1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, x = 0;


            Console.WriteLine(" Unesi vrijednost 1.varijable. ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine(" Unesi vrijednost 2.varijable. ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine(" Unesi vrijednost 3.varijable. ");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine(" Unesi vrijednost 4.varijable. ");
            d = double.Parse(Console.ReadLine());

            x = (a * a + b * b + c * c + d * d) / ((a + b) * (a + b) + (c + d) * (c + d));

            Console.WriteLine(x + " ---> to je vrijednost za x. ");

            Console.ReadKey();
        }
    }
}
