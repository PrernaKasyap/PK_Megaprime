using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaPrimesProgram
{
    class ClsMegaprime_UsingRecursion
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="inputnumber">Takes input as numer which is entered</param>
        /// <returns></returns>
        public static List<uint> GetMegaprimeNumbers(uint inputnumber)
        {
            var megaprimes = new List<uint>(); //List to add all megaprime no's
            CheckIfRecursive(2, inputnumber, megaprimes);
            return megaprimes;
        }

        /// <summary>
        /// Method is ued to check if number below or equal to input number is Megaprime.
        /// </summary>
        /// <param name="defaultstart"> it is set as 2</param>
        /// <param name="inputno">enetered number</param>
        /// <param name="megaprimes">provides list of megaprime after doing check</param>
        private static void CheckIfRecursive(uint defaultstart, uint inputno, List<uint> megaprimes)
        {
            if (defaultstart > inputno) return; // input entered < 2
            if (CheckPrime(defaultstart) && IsMegaPrime(defaultstart))
            {
                megaprimes.Add(defaultstart);
            }
            CheckIfRecursive(defaultstart + 1, inputno, megaprimes);
        }

        /// <summary>
        /// Below method is used to check if given number is prime or not.
        /// </summary>
        /// <param name="number">input field</param>
        /// <returns></returns>
        private static bool CheckPrime(uint number)
        {
            if (number <= 1) return false; 
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            //loop will continue executing as long as the value of i is less than or equal to the square root of the number
            //this loop will run only for odd no's
            for (uint i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static bool IsMegaPrime(uint numberToCheck)
        {
            //Iterate through each digit in the integer numberToCheck.            
            bool isMegaPrime = true;
            var splitDigits = GetSplitDigits(numberToCheck);
            foreach (var digit in splitDigits)
            {
                if (!CheckPrime(digit))
                {
                    isMegaPrime = false;
                    break;
                }
            }
            return isMegaPrime;
        }

        /// <summary>
        /// Method used to split input number.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
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
    }
}