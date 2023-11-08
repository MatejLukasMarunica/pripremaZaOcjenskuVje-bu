using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pripremaZaOcjenskuVjezbu3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nesto, s1, s2;

            Console.WriteLine(" Unesi neku rečenicu. ");
            nesto = Convert.ToString(Console.ReadLine());

            Console.WriteLine(nesto.Substring(0, nesto.IndexOf(" ")));
            Console.Write(nesto.Substring(nesto.LastIndexOf(" ", nesto.Length -1)));



            Console.ReadKey();
        }
    }
}
