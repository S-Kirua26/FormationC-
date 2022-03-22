using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class Euclide
    {
        public static int Pgcd(int a, int b)
        {
            for (int i = b; i >= 1; i--)
            {
                if (a % i == 0 && b % i == 0) // si le reste de la division de a par i == 0 ET que le reste de la division de b par i == 0
                    return i;
            }

            return 0;
        }

        public static int PgcdRecursive(int a, int b)
        {

            int r = a % b;
            if (r == 0)
            {
                return b;
            }
            return PgcdRecursive(b, r);
        }
    }
}
