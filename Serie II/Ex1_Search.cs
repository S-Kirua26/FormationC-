using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    public static class Search
    {
        public static int LinearSearch(int[] tableau, int valeur)
        {
           for (int i = 0; i < tableau.Length; i++)
           {
                if (valeur == tableau[i])
                {
                    Console.WriteLine($"Valeur trouvé à la position {i}");
                    return i;
                }
           }
            return -1;
        }

        public static int BinarySearch(int[] tableau, int valeur)
        {
            int gauche = 0;
            int droite = tableau.Length - 1;

            while (gauche <= droite)
            {
                int milieu = (gauche + droite) / 2;
                if (tableau[milieu] == valeur)
                {
                    Console.WriteLine($"Valeur trouvé à la position {milieu}");
                    return milieu;
                }
                else if (tableau[milieu] < valeur)
                {
                    gauche = milieu + 1;
                }
                else
                {
                    droite = milieu - 1;
                }
            }
            Console.WriteLine($"Valeur {valeur} non trouvé");
            return -1;
        }
    }
}
