using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class Pyramid
    {
        public static void PyramidConstruction(int n, bool isSmooth)
        {
            for (int i = 1; i <= n; i++)  // permet de commencer à 1 le haut de la pyramide
            {
                for (int j = 1; j <= (2 * n) - 1; j++)
                {
                    if (j > n - i && j < n + i) // ajout de données si la position de j est plus grand que la hauteur - i et plus petit que la hauteur + i
                    {
                        if (i % 2 == 0 && isSmooth)
                        {
                            Console.Write("-");
                        }
                        else
                        {
                            Console.Write("+");
                        }
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
