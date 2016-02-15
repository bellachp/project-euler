using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The sum of the squares of the first ten natural numbers is,
//12 + 22 + ... + 102 = 385
//The square of the sum of the first ten natural numbers is,
//(1 + 2 + ... + 10)2 = 552 = 3025
//Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
//Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.


namespace project_euler
{
    class Program
    {

        private static int sumOfSquares(int number)
        {
            int sum = 0;
            for (int num = 1; num <= number; num++)
            {
                sum += num * num;
            }
            return sum;
        }

        private static int squareOfSums(int number)
        {
            int sum = 0;
            for (int num = 1; num <= number; num++)
            {
                sum += num;
            }
            int square = sum * sum;
            return square;
        }

        static void Main()
        {
            int numNaturals = 100;
            int diff = squareOfSums(numNaturals) - sumOfSquares(numNaturals);

            Console.WriteLine("Answer is {0}", diff);
            Console.ReadKey();
        }

    }
}
