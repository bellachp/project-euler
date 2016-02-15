using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

/*
A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
a^2 + b^2 = c^2

For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.
*/


namespace project_euler
{
    class Program
    {
        private static bool Condition(int a, int b, int c)
        {
            if (a + b + c == 1000)
            { return true; }
            else return false;
        }

        static void Main()
        {
            int answer = 0;
            int c = 2;
            while (answer == 0)
            {
                c++;
                for (int b = 1; b < c; b++)
                {
                    for (int a = 1; a < b; a++)
                    {
                        if (a*a + b*b == c*c)
                        {
                            if (Condition(a, b, c))
                            {
                                answer = a * b * c;
                                Console.WriteLine("{0}^2 + {1}^2 = {2}^2 and sums to 1000.", a, b, c);
                            }
                        }
                    }
                }
            }
            
            Console.WriteLine("Answer is {0}", answer);
            Console.ReadKey();
        }

    }
}
