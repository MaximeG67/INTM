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
            int c;
            switch (operation)
            {
                case '+':
                    c = a + b;
                    Console.WriteLine($"{a} + {b} = {c} ");
                    break;
                case '-':
                    c = a - b;
                    Console.WriteLine($"{a} - {b} = {c}");
                    break;
                case '*':
                    c = a * b;
                    Console.WriteLine($"{a} * {b} = {c}");
                    break;
                case '/':
                    if (b == 00)
                    {
                        Console.WriteLine("Opération impossible");
                    }

                    else
                    {
                        c = a / b;
                        Console.WriteLine($"{a} / {b} = {c}");
                    }
                    break;
                default:
                    Console.WriteLine("Opération invalide");
                    break;
            }
        }

        public static void IntegerDivision(int a, int b)
        {
            int q;
            int r;

            if (b == 0)
            {
                Console.WriteLine($"{a} : {b} = Opération invalide.");
            }
            else
            {
                r = a % b;
                q = a / b;


                if (r == 0)
                {
                    Console.WriteLine($"{a} = {q} * {b}");
                }
                else
                {
                    Console.WriteLine($"{a} = {q} * {b} + {r}");
                }
            }

        }

        public static void Pow(int a, int b)
        {
            int p = 1;

            if (b < 0)
            {
                Console.WriteLine("Opération invalide");
            }
            else
            {
                for (int i = 0; i < b ; i++)
                {
                    p = p * a;
                }
                Console.WriteLine($"{a} ^ {b} = {p}");
            }

  
        }
    }
}
