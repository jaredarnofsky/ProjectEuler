using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problems from: projecteuler.net

            try
            {
                //Problem 1: 
                Console.WriteLine("Problem 1: If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.");
                Console.WriteLine("Find the sum of all the multiples of 3 or 5 below 1000.");

                int Sum = 0;

                //Find all multiples of 3 and 5 below 1000
                for (int i = 1; i < 1000; i++)
                {
                    //If the remainder is zero it is a multiple
                    if ((i % 3 == 0) || (i % 5 == 0))
                    {
                        //Add to the sum
                        Sum += i;
                    }
                }

                Console.WriteLine("Answer : " + Sum + "\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message + "\n");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
