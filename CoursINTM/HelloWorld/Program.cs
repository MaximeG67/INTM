using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rentez votre nom et prénom");

            string fname = Console.ReadLine();

            Console.WriteLine("Hello " + fname + "! " + fname.Length);

            fname = "Toto";
            Console.WriteLine($"Hello {fname} ! {fname.Length}");

            Console.ReadKey();
        }
    }
}
