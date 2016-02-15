using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A palindromic number reads the same both ways. 
//The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
//Find the largest palindrome made from the product of two 3-digit numbers.

namespace project_euler
{
    class Program
    {

        private static bool IsPalindrome(int product)
        {
            string num = product.ToString();
            char[] reverse = num.ToCharArray();
            Array.Reverse(reverse);
            string reverseNum = new String(reverse);
            if (num == reverseNum)
            {
                return true;
            }
            return false;
        }

        private static int NumDigits(int factor)
        {
            return (int)Math.Floor(Math.Log10(factor) + 1);
        }

        private static bool HasFactorDigitsNeeded(int palindrome)
        {
            for (int div = 100; div < 1000; div++)
            {
                if (palindrome % div == 0)
                {
                    int otherDivisor = palindrome / div;
                    if (NumDigits(otherDivisor) == 3)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static void Main()
        {
            int limitProduct = 999 * 999; // max product of 3 digit numbers
            int minProduct = 100 * 100; // min product of 3 digit numbers
            int answer = 0;
            
            for (int k = minProduct; k < limitProduct; k++)
            {
                if (IsPalindrome(k))
                {
                    if (HasFactorDigitsNeeded(k))
                    {
                        Console.WriteLine(k + "is a product of two 3-digit numbers");
                        answer = k;
                    }                        
                }
            }

            Console.WriteLine("Answer is {0}", answer);
            Console.ReadKey();
        }

    }
}
