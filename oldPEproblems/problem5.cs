using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

namespace project_euler
{
    class Program
    {

        static void Main()
        {

            int answer = 0;
            int k = 20;
            while (answer == 0)
            {
                bool searching = true;
                for (int num = 2; num < 21; num++ )
                { 
                    if (searching && k % num != 0)
                    {                        
                        searching = false;
                    }
                    if (!searching) 
                    {
                        k++;
                        break; 
                    }    
                    else if (num == 20)
                    {
                        answer = k;
                    }
                }                
            }
            Console.WriteLine("Answer is {0}", answer);
            Console.ReadKey();
        }

    }
}
