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
                //Problem 4: 
                Console.WriteLine("Problem 4: A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99");
                Console.WriteLine("Find the largest palindrome made from the product of two 3-digit numbers.");

                int MaxPalindrone = 0;

                //We loop through each number and multiply everyone by 1000. Ex: 1 X 1, 1 x 2 up to 1000 then 2 x 1, 2 x 2 up to 1000 and keep track of the biggest palindrone that we have
                for (int i = 0; i < 1000; i++)
                {
                    for (int j = i; j < 1000; j++)
                    {
                        int CurrentProduct = i * j;

                        //Check if it is a palindrone
                        bool IsPalindrone = Palindrome(CurrentProduct);

                        //If yes, make sure it is bigger than the max one we have already
                        if (IsPalindrone && (CurrentProduct > MaxPalindrone))
                        {
                            MaxPalindrone = CurrentProduct;
                        }
                    }
                }                

                Console.WriteLine("Answer : " + MaxPalindrone);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }

        static bool Palindrome(int CurrentProduct)
        {
            //Convert to string, then to a char array so we know what index has what value
            char[] CurrentProductArray = CurrentProduct.ToString().ToCharArray();

            //Initialize a new array of the same size
            char[] ReversedCurrentProductArray = new char[CurrentProductArray.Length];

            //Reverse the original array into the new array
            int j = 0;
            for (int i = CurrentProductArray.Length - 1; j <= CurrentProductArray.Length - 1; i--)
            {
                ReversedCurrentProductArray[j] = CurrentProductArray[i];
                j++;
            }

            //create a string and see if they are equal
            if (new String(ReversedCurrentProductArray) == new String(CurrentProductArray))
                return true;
            else
                return false;
        }
    
    }
}
