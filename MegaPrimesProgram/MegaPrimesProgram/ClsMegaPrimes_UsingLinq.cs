using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaPrimesProgram
{
    class ClsMegaPrimes_UsingLinq
    {
        /// <summary>
        /// Returns you a list of all MegaPrime numbers up and including the number passed
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static List<uint> GetMegaPrime(uint number)
        {
            //Initiate our output
            List<uint> output = new List<uint>();


            //Loop through all previous numbers and itself checking if each one is prime 
            //and if each digit in the number is prime and adding to a list if successful
            for (uint i = 0; i <= number; i++)
                if (IsPrime(i) && i.ToString().Where(c => IsPrime((uint)char.GetNumericValue(c))).Count() == i.ToString().Length)
                    output.Add(i);

            //return all of the added numbers 
            return output;
        }

        /// <summary>
        /// Checks whether a number is prime returing a boolean
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static bool IsPrime(uint number)
        {
            //return true for 2 as the exception to the rules
            if (number == 2) return true;

            //return false if the number is 1 or less and even
            if (number <= 1 || number % 2 == 0) return false;

            //Gets the maximum number our input will be divisible by 
            uint boundary = (uint)Math.Floor(Math.Sqrt(number));

            //loop through all, checking for a perfect division leaving out unnecessary checks
            for (uint i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            //if false was never returned the number is prime
            return true;
        }
    } }