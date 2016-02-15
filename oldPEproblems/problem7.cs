using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
//What is the 10 001st prime number?


namespace project_euler
{
    class Program
    {
        private static bool IsPrime(uint number)
        {
            for (uint k = 2; k*k  <= number; k++)
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
            int primeCount = 0;
            int desiredPrime = 10001;
            uint num = 1;

            while (primeCount < desiredPrime)
            {
                num++;
                if (IsPrime(num))
                {
                    primeCount++;
                }
            }

            Console.WriteLine("Answer is {0}", num);
            Console.ReadKey();
        }

    }
}
