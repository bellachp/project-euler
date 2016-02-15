using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The prime factors of 13195 are 5, 7, 13 and 29.
//What is the largest prime factor of the number 600851475143 ?

namespace project_euler
{
    class Program
    {

        private static bool IsPrime(long factor)
        {
            for (long k = 2; k < factor; k++)
            {
                if (factor % k == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main()
        {
            long num = 600851475143;
            long checkFactor = 3;
            double limit = Math.Floor(Math.Sqrt(num));
            List<long> primeFactors = new List<long>();

            while (checkFactor < limit)
            {
                if (num % checkFactor == 0 && IsPrime(checkFactor))
                {
                    primeFactors.Add(checkFactor);
                    Console.WriteLine("factor added {0}", checkFactor);                                        
                }
                checkFactor += 2;
            }

            Console.WriteLine("Answer is {0}", primeFactors.Max());
            Console.ReadKey();
        }

    }
}
