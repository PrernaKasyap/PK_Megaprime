using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaPrimesProgram
{
    class clsMegaprime_UsingLoops
    {
        public static List<uint> GetMegaPrimes(uint maxNumber)
        {
            //List of megaprimes
            List<uint> megaprimes = new List<uint>();

            //anything less than 2 is not prime
            for (uint i = 1; i <= (uint)maxNumber; i++)
            {
                if (IsPrime(i))
                {
                    if (i < 10) //if it's not more than 1 digit
                    {
                        megaprimes.Add(i);
                    }
                    else
                    {
                        if (IsMegaPrime(i))
                        {
                            megaprimes.Add(i);
                        }
                    }
                }
            }
            return megaprimes;
        }

        private static bool IsPrime(uint numberToCheck)
        {
            if (numberToCheck == 1)
            {
                return false;
            }

            for (uint i = 2; i <= numberToCheck - 1; i++)
            {
                //n-1 because you don't need to check if it can divide by itself, so every number from 2 to one less than itself 

                if (numberToCheck % i == 0)  // Modulus operator returns the division remainder                                              
                                             // Return false if there is an iteration where there is no remainder
                    return false;
            }

            return true;    // a prime number always has a remainder.
        }

        public static uint[] GetSplitDigits(uint number)
        {
            string temp = number.ToString();
            uint[] lstSplitDigit = new uint[temp.Length];
            for (int i = 0; i < lstSplitDigit.Length; i++)
            {
                lstSplitDigit[i] = uint.Parse(temp[i].ToString());
            }
            return lstSplitDigit;
        }

        private static bool IsMegaPrime(uint numberToCheck)
        {
            //Iterate through each digit in the uinteger numberToCheck. 
            uint[] splitDigits;
            bool isMegaPrime = true;

            splitDigits = GetSplitDigits(numberToCheck);

            foreach (uint digit in splitDigits)
            {
                if (IsPrime(digit) == false)
                {
                    isMegaPrime = false;
                    break;
                }
            }
            return isMegaPrime;
        }
    }
}
