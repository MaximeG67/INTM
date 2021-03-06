using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_III
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercice I - Conseil de classe
            Console.WriteLine("------------------------------");
            Console.WriteLine("Exercice I - Conseil de classe");
            Console.WriteLine("------------------------------");

            string path = Directory.GetCurrentDirectory();
            string input = path + @"\class.txt";
            string output = path + @"\result.txt";
            ClassCouncil.SchoolMeans(input, output);
            //Console.WriteLine(input);

            #endregion
            #region Exercice II - Performances des tris
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Exercice II - Performances des tris");
            Console.WriteLine("-----------------------------------");

            //int[] a = { 6, 4, 8, 2, 9, 3, 9, 4, 7, 6, 1 };
            //int[] b = { 6, 4, 8, 2, 9, 3, 9, 4, 7, 6, 1 };

            //List<int[]> lst = SortingPerformance.ArraysGenerator(100);
            //Console.WriteLine(SortingPerformance.UseInsertionSort(lst[0]) + " ms");
            //Console.WriteLine(SortingPerformance.UseQuickSort(lst[1]) + " ms");
            //SortingPerformance.PerformanceTest(20000,10);
            List<int> sizes = new List<int> { 2000, 5000, 10000 };
            //SortingPerformance.PerformancesTest(sizes, 10);

            int count = 10;
            SortingPerformance.DisplayPerformances(sizes, count);
            #endregion


            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
