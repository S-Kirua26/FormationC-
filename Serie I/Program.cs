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
            //ElementaryOperations.BasicOperation(1, 5, 'T');
            //ElementaryOperations.BasicOperation(3, 4, '+');
            // ElementaryOperations.BasicOperation(3, 4, '-');
            // ElementaryOperations.BasicOperation(3, 4, '*');
            // ElementaryOperations.BasicOperation(3, 4, '/');
            //ElementaryOperations.BasicOperation(0, 4, '/');
            //ElementaryOperations.BasicOperation(3, 0, '/');

            // ElementaryOperations.IntegerDivision(12, -4);
            // ElementaryOperations.IntegerDivision(13, -4);
            // ElementaryOperations.IntegerDivision(13, 0);

            //ElementaryOperations.Pow(12, 4);
            //ElementaryOperations.Pow(10, 3);

            //SpeakingClock.GoodDay(1);
            //SpeakingClock.GoodDay(2);
            //SpeakingClock.GoodDay(3);
            //SpeakingClock.GoodDay(4);
            //SpeakingClock.GoodDay(5);
            //SpeakingClock.GoodDay(6);
            //SpeakingClock.GoodDay(7);
            //SpeakingClock.GoodDay(8);
            //SpeakingClock.GoodDay(9);
            //SpeakingClock.GoodDay(10);
            //SpeakingClock.GoodDay(11);
            //SpeakingClock.GoodDay(12);
            //SpeakingClock.GoodDay(13);
            //SpeakingClock.GoodDay(14);
            //SpeakingClock.GoodDay(15);
            //SpeakingClock.GoodDay(16);
            //SpeakingClock.GoodDay(17);
            //SpeakingClock.GoodDay(18);
            //SpeakingClock.GoodDay(19);
            //SpeakingClock.GoodDay(20);
            //SpeakingClock.GoodDay(21);
            //SpeakingClock.GoodDay(22);
            //SpeakingClock.GoodDay(23);

            //Pyramid.PyramidConstruction(10, true);
            //Pyramid.PyramidConstruction(10, false);

            //Console.WriteLine(Factorial.Factorial_(5));
            //Console.WriteLine(Factorial.FactorialRecursive(5));

            //PrimeNumbers.DisplayPrimes();

            Console.WriteLine(Euclide.Pgcd(12, -4));
            Console.WriteLine(Euclide.Pgcd(12, 4));
            Console.WriteLine(Euclide.Pgcd(144, 28));

            Console.WriteLine(Euclide.PgcdRecursive(12, 4));


            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
