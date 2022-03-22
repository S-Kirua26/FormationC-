using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    public static class Eratosthene
    {
        public static int[] EratosthenesSieve(int n)
        {
            int[] tableauEra = new int[n + 1]; // nouveau tableau avec la taille + 1 ( comme on commence à 0)
            for (int i = 0; i < tableauEra.Length; i++) // je percours mon tableau jusqu'à arrivé à la fin
            {
                tableauEra[i] = i; // on ajoute la valeur de i à l'indice du tableau i
            }

            for (int i = 2; i <= (int)Math.Sqrt(n) + 1; i++) 
            {
                for (int j = 2; i * j < tableauEra.Length; j++) // pour supprimer les multiples ( on commence à 2, puis on multiplie i par j et on regarde si elle est plus petite que la taille du tableau )
                {
                    tableauEra[i * j] = int.MinValue; // on ajoute une valeur absurde au multiple  
                }
            }
            return new int[0];
        }
    }
}
