using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opérations de base
            ElementaryOperations.BasicOperation(3, 4, '+');
            ElementaryOperations.BasicOperation(6, 2, '/');
            ElementaryOperations.BasicOperation(2, 0, '/');
            ElementaryOperations.BasicOperation(3, 4, 'L');

            ElementaryOperations.IntegerDivision(12,-4);
            ElementaryOperations.IntegerDivision(13,-4);
            ElementaryOperations.IntegerDivision(12, 0);

            ElementaryOperations.Pow(10, 3);
            ElementaryOperations.Pow(10, 3);

            SpeakingClock.GoodDay(DateTime.Now.Hour);


            Console.WriteLine(Factorial.Factorial_(5));
            Pyramid.PyramidConstruction(11,false);


            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
