using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaPrimesProgram
{
    class Program
    {        
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            while (true)
            {
                uint input;
                Console.WriteLine("Please enter a number to find the Megaprime below or equal to that...");
                input = Convert.ToUInt32(Console.ReadLine());
                
                // Approach 1
                Console.WriteLine("------------Using Linq-------------");
                Console.WriteLine($"The mega prime numbers are {string.Join(", ", ClsMegaPrimes_UsingLinq.GetMegaPrime(input))}");

                // Approach 2
                Console.WriteLine("------------Using Simple Loops-------------");
                Console.WriteLine($"The mega prime numbers are {string.Join(", ", clsMegaprime_UsingLoops.GetMegaPrimes(input))}");

                // Approach 3
                Console.WriteLine("------------Using Recursion-------------");
                Console.WriteLine($"The mega prime numbers are {string.Join(", ", ClsMegaprime_UsingRecursion.GetMegaprimeNumbers(input))}");
               
                Console.WriteLine("To continue finding Megaprime , please press enter key !");
                Console.ReadKey();                
            }            
        }
    }
}
