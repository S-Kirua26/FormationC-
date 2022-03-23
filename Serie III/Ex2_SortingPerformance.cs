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
            Console.WriteLine("n;MeanInsertion,StdInsertion;MeanQuick,StdQuick");
            List<SortData> datas = PerformancesTest(sizes, count);
            for (int i =0; i < datas.Count; i++)
            {
                Console.WriteLine($"{sizes[i]}, {datas[i].InsertionMean}, {datas[i].QuickMean}");
            }
        }

        public static List<SortData> PerformancesTest(List<int> sizes, int count)
        {
            List<SortData> listePerf = new List<SortData>();
            
            for (int i =0; i < sizes.Count; i++)
            {
                listePerf.Add(PerformanceTest(sizes[i], count));
            }
            return listePerf;
        }

        public static SortData PerformanceTest(int size, int count)
        {
            long moyenne1 = 0;
            long moyenne2 = 0;

            for (int i =0; i < count; i++)
            {
                List<int[]> listePerf = ArraysGenerator(size);

                moyenne1 += UseInsertionSort(listePerf[0]);
                moyenne2 += UseQuickSort(listePerf[1]);
            }

            moyenne1 = moyenne1 / count;
            moyenne2 = moyenne2 / count;

            SortData structure = new SortData();
            structure.InsertionMean = moyenne1;
            structure.QuickMean = moyenne2;
            return structure;
        }

        private static List<int[]> ArraysGenerator(int size)
        {
            List<int[]> liste = new List<int[]>();
            int[] tableau1 = new int[size];
            int[] tableau2 = new int[size];
            Random random = new Random();

            for (int i=0; i < size; i++)
            {
                int nbRandom = random.Next(-1000, 1001);
                tableau1[i] = nbRandom;
                tableau2[i] = nbRandom;
            }
            liste.Add(tableau1);
            liste.Add(tableau2);
            return liste;
        }

        public static long UseInsertionSort(int[] array)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
                InsertionSort(array);

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            return stopwatch.ElapsedMilliseconds;
        }

        public static long UseQuickSort(int[] array)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
                QuickSort(array, 0, array.Length - 1);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            return stopwatch.ElapsedMilliseconds;
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
