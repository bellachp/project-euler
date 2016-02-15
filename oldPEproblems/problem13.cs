using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

/*
problem 13
Work out the first ten digits of the sum of the following one-hundred 50-digit numbers.
 -- numbers are in txt file
*/

namespace project_euler
{
    class Program
    {
        private static void ParseNumberFile(string filename, List<int[]> numberHolder)
        {
            string[] fileContent = File.ReadAllLines(filename);
            foreach (string num in fileContent)
            {
                int[] digits = num.Select(x => int.Parse(x.ToString())).ToArray();
                numberHolder.Add(digits);
            }
        }

        static void Main()
        {
            string filename = "C:/Users/uz135d/Documents/project euler/p13bigNums.txt";
            List<int[]> bigNums = new List<int[]>(100);
            ParseNumberFile(filename, bigNums);

            int[] bigSum = new int[50];
            int remainder = 0;
            for (int k = 49; k > -1; k--)
            {
                int digitSum = 0;
                int onesDigit;

                foreach (int[] bigNum in bigNums)
                {
                    digitSum += bigNum[k];
                }
                digitSum += remainder;
                onesDigit = digitSum % 10;
                bigSum[k] = onesDigit;
                remainder = (digitSum - onesDigit) / 10;
            }

            string firstTenDigits = remainder.ToString();
            int digitCount = firstTenDigits.Length;
            for (int k = 0; k < 10 - digitCount; k++)
            {
                firstTenDigits += bigSum[k].ToString();
            }

            Console.WriteLine("Answer is {0}", firstTenDigits);
            Console.ReadKey();
        }

    }
}
