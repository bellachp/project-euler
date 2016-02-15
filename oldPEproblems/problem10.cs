using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
Find the sum of all the primes below two million.
*/


namespace project_euler
{
    class Program
    {
        private static bool IsPrime(uint number)
        {
            if (number == 3)
                return true;
            else if (number % 3 == 0)
                return false;
            for (uint k = 5; k*k <= number; k += 2)
            {
                if (number % k == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main()
        {
            Stopwatch tic = new Stopwatch();
            tic.Start();
            long sum = 2;
            uint limit = 2000000;

            for (uint k = 3; k < limit; k += 2)
            {
                if (IsPrime(k))
                {
                    sum += k;
                }
            }

            tic.Stop();
            Console.WriteLine("time {0}", tic.Elapsed.TotalSeconds);
            Console.WriteLine("Answer is {0}", sum);
            Console.ReadKey();
        }

    }
}
