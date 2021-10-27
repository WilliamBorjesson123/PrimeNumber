using System;
using System.Collections.Generic;

namespace PrimeNumber
{
    internal class Program : PrimeNumberAlgorithm
    {
        private static void Main(string[] args)
        {
            PrimeNumber();
        }

        /// <summary>
        /// Method for the user to type, checks if it's a number or not.
        /// Also let's the user to chose what to do next.
        /// </summary>
        private static void PrimeNumber()
        {
            var primeNumberList = new List<int>();
            var isThisAPrimeNumber = true;

            while (isThisAPrimeNumber)
            {
                var userNumber = UserInput;
                if (userNumber == 0)
                {
                    Console.WriteLine("That is not a number, please try again!");
                    continue;
                }

                var isPrimeNumber = IsPrime(userNumber);

                if (isPrimeNumber)
                {
                    primeNumberList.Add(userNumber);
                    Console.WriteLine("{0} This is a prime number", userNumber);
                }
                else
                {
                    Console.WriteLine("{0} This is not a prime number", userNumber);
                }

                var isThisAPrimeNumber2 = true;
                while (isThisAPrimeNumber2)
                {
                    Console.WriteLine("What do you want to do? [P]Print the prime numbers you have put in, [R]Recive the next prime number, [T]Try again [E]Exit the program");

                    var answer = Console.ReadLine();

                    switch (answer.ToUpper())
                    {
                        case "P":
                            primeNumberList.Sort();
                            foreach (var number in primeNumberList)
                            {
                                Console.WriteLine(number);
                            }
                            break;

                        case "R":
                            primeNumberList.Sort();
                            var highestPrimeNumber = primeNumberList[primeNumberList.Count - 1];
                            var reciveNextPrimeNumber = GetNextPrimeNumber(highestPrimeNumber);
                            Console.WriteLine(reciveNextPrimeNumber);
                            primeNumberList.Add(reciveNextPrimeNumber);
                            break;

                        case "T":
                            isThisAPrimeNumber2 = false;
                            break;

                        case "E":
                            isThisAPrimeNumber2 = false;
                            isThisAPrimeNumber = false;
                            break;

                        default:
                            Console.WriteLine("Wrong type of input, please try again!");
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Method to get the next prime number in line.
        /// </summary>
        /// <param name="highestCurrentPrime"></param>
        /// <returns></returns>
        private static int GetNextPrimeNumber(int highestCurrentPrime)
        {
            highestCurrentPrime++;
            while (!IsPrime(highestCurrentPrime))
            {
                highestCurrentPrime++;
            }
            return highestCurrentPrime;
        }

        /// <summary>
        /// Method for the user to see if it's a prime number or not.
        /// </summary>
        public static int UserInput
        {
            get
            {
                Console.Write("Type a number to see if it's a prime number: ");
                var success = int.TryParse(Console.ReadLine(), out int number);
                if (success)
                {
                    return number;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
