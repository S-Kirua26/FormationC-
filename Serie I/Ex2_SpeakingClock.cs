using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class SpeakingClock
    {
        public static string GoodDay(int heure)
        {
            switch (heure)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine($"Il est {heure} Merveuilleuse nuit");
                    break;

                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                    Console.WriteLine($"Il est {heure} Bonne matinée");
                break;

                case 12:
                    Console.WriteLine($"Il est {heure} Bonne appétit");
                break;

                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                    Console.WriteLine($"Il est {heure} Profitez de votre aprés-midi");
                break;

                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                    Console.WriteLine($"Il est {heure} Passez une bonne soirée");
                break;

                default:
                    Console.WriteLine("C'est une heure impossible");
                    break;
            }
            return string.Empty;
            Console.ReadLine();
        }
    }
}
