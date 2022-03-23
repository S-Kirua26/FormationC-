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
            string path = Directory.GetCurrentDirectory();

            ClassCouncil.SchoolMeans(path + @"\Entree.txt", path + @"\Sortie.txt");

            SortingPerformance.DisplayPerformances(new List<int> { 2000, 5000, 10000}, 50);


            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
