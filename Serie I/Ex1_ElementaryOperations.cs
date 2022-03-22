using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class ElementaryOperations
    {
        public static void BasicOperation(int a, int b, char operation)
        {
            float resultat = 0;

            switch (operation)
            {
                case '+':
                    resultat = a + b;
                    Console.WriteLine($"{a} + {b} = {resultat}");
                    break;

                case '-':
                    resultat = a - b;
                    Console.WriteLine($"{a} - {b} = {resultat}");
                    break;

                case '*':
                    resultat = a * b;
                    Console.WriteLine($"{a} * {b} = {resultat}");
                    break;

                case '/':
                    if (a == 0 || b == 0)
                    {
                        Console.WriteLine($"{a} {operation} {b} = Operation impossible");
                    }
                    else
                    {
                        resultat = a / b;
                        Console.WriteLine($"{a} / {b} = {resultat}");
                    }
                    break;

                default:
                    Console.WriteLine($"{a} {operation} {b} = Operation impossible");
                    break;
            }
            Console.ReadLine();

        }

        public static void IntegerDivision(int a, int b)
        {
            switch (b)
            {
                case 0:
                    Console.WriteLine($"{a} : {b} = Operation invalide");
                break;

                default:
                    int quotient = a / b;
                    int reste = a % b;

                    if (reste == 0)
                    {
                        Console.WriteLine($"{a} = {quotient} * {b}");
                    }
                    else
                    {
                        Console.WriteLine($"{a} = {quotient} * {b} + {reste}");
                    }
                break;
            }
            Console.ReadLine();
        }

        public static void Pow(int a, int b)
        {
            switch (b)
            {
                case 0:
                    Console.WriteLine("Operation invalide");
                    break;

                default:
                    int resultat = a ^ b;
                    Console.WriteLine($"{a} ^ {b} = {resultat}");
                    break;
            }
            Console.ReadLine();
        }
    }
}
