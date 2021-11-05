using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_III
{
    public struct SortData
    {
        /// <summary>
        /// Moyenne pour le tri par insertion
        /// </summary>
        public long InsertionMean { get; set; }
        /// <summary>
        /// Écart-type pour le tri par insertion
        /// </summary>
        public long InsertionStd { get; set; }
        /// <summary>
        /// Moyenne pour le tri rapide
        /// </summary>
        public long QuickMean { get; set; }
        /// <summary>
        /// Écart-type pour le tri rapide
        /// </summary>
        public long QuickStd { get; set; }
    }

    public static class SortingPerformance
    {
        public static void DisplayPerformances(List<int> sizes, int count)
        {
            List<SortData> sortin = PerformancesTest(sizes, count);
            foreach (SortData data in sortin)
            {
                Console.WriteLine(data.InsertionMean);
            }
        }

        public static List<SortData> PerformancesTest(List<int> sizes, int count)
        {
            List<SortData> sortin = new List<SortData>();

            foreach (int size in sizes)
            {
                sortin.Add(PerformanceTest(size, count));
            }

            return sortin;
        }

        public static SortData PerformanceTest(int size, int count)
        {
            long[] insert = new long[count];
            long[] quick = new long[count];
            SortData sort = new SortData();

            for (int i = 0; i < count; i++)
            {

                List<int[]> data = ArraysGenerator(size);
                insert[i] = UseInsertionSort(data[0]);
                quick[i] = UseQuickSort(data[1]);
            }
            sort.InsertionMean = (long)insert.Average();
            sort.QuickMean = (long)quick.Average();
            sort.InsertionStd = EcartType(insert);
            sort.QuickStd = EcartType(quick);

            return sort;
        }

        private static List<int[]> ArraysGenerator(int size)
        {
            int[] arr = new int[size];
            int[] arr2 = new int[size];
            Random r = new Random();
            for (int i = 0; i < size; i++)
            {
                int rndNbr = r.Next(-1000, 1001);
                arr[i] = rndNbr;
                arr2[i] = rndNbr;
            }
            return new List<int[]> { arr, arr2 };
        }


        public static long UseInsertionSort(int[] array)
        {
            Stopwatch watch = Stopwatch.StartNew();
            InsertionSort(array);
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        private static long EcartType(long[] tab)
        {
            long res = 0;
            if (tab.Length > 0)
            {
                long avg = (long)tab.Average();
                long sum = (long)tab.Sum(d => Math.Pow(d - avg, 2));
                res = (long)Math.Sqrt(sum / tab.Length - 1);
            }
            return res;
        }


        public static long UseQuickSort(int[] array)
        {
            Stopwatch s = Stopwatch.StartNew();
            QuickSort(array, 0, array.Length - 1);
            s.Stop();
            return s.ElapsedMilliseconds;
        }

        private static void InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        int tmp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = tmp;
                    }
                }
            };
        }

        private static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);
                QuickSort(array, left, pivot - 1);
                QuickSort(array, pivot + 1, right);
            }
        }

        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left;
            for (int j = left; j < right; j++)
            {
                if (array[j] < pivot)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                }
            }
            int tmp = array[i];
            array[i] = array[right];
            array[right] = tmp;
            return i;
        }
    }
}
