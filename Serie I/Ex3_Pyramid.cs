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
            for (int i = 1; i <= n; i++)
            {
                int g = n- i + 1;
                int d = n +i - 1;
                for (int j = 1; j <= 2 * n - 1; j++)
                {
                    if (g <= j && d >= j)
                    {
                        if (!isSmooth && i % 2 == 0)
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
