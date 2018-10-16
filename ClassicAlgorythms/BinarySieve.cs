using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassicAlgorithms
{
    public class BinarySieve
    {
        public static void ExecuteBinaryAndSieve()
        {
            BinarySieve sieve = new BinarySieve();
            IMenuController alg = new Algorythms() as IMenuController;

            int maxPrimeSetSize;

            if (!int.TryParse(Console.ReadLine(), out maxPrimeSetSize))
            {
                Console.WriteLine("Not a number. Bhye, Bhye!");
                Console.ReadLine();

                alg.MainMenu();
            }
            if (maxPrimeSetSize > 500000)
            {
                Console.WriteLine("The number was larger than 500.000. We don't have all day here...");
                Console.ReadLine();
                return;
            }
            DateTime startTime = DateTime.Now;
            sieve.BinarySearch(sieve.SieveOfEratostenes(maxPrimeSetSize));
            DateTime endTime = DateTime.Now;
            string deltaTime = (endTime - startTime).TotalSeconds.ToString();
            Console.WriteLine($"\nExecution time was {deltaTime} seconds");
            Console.ReadLine();

            alg.MainMenu();
        }

        //private static void FlushKeyboard()
        //{
        //    while (Console.In.Peek() != -1)
        //        Console.In.ReadLine();
        //}

        /// <summary>
        /// Simple binary search
        /// </summary>
        /// <param name="listOfNumbers"></param>
        private void BinarySearch(List<long> listOfNumbers)
        {
            List<long> set = new List<long>();
            bool solved = false;
            set = listOfNumbers;

            Console.WriteLine($"Max number of searches should be: {(int)Math.Log(set.Count, 2) + 1}");

            Random rnd = new Random();
            int elem = rnd.Next(0, listOfNumbers.Count);

            int min = 0, max = set.Count - 1;

            if (elem < set[min] || elem > set[max])
            {
                Console.WriteLine($"Element {elem} does not exist in the array");
                Console.ReadLine();
            }

            int counter = 0;

            while (min < max && !solved)
            {
                int avg = (int)Math.Floor(((decimal)max + (decimal)min) / 2);

                if (elem == set[avg])
                {
                    Console.WriteLine($"Element {elem} was found at postion {avg}");
                    Console.WriteLine($"Number of iterations: {counter}");
                    Console.ReadLine();
                    solved = true;
                }
                else
                {
                    if (elem < set[avg])
                        max = avg - 1;
                    else
                        min = avg + 1;
                }

                counter++;
            }

            Console.WriteLine($"Element {elem} does not exist in the array");
            Console.WriteLine($"Number of iterations: {counter}");
            Console.ReadLine();
        }

        /// <summary>
        /// Finds all the prime numbers up to maxNumber.
        /// If the number is larger than n, an out of memory exception will be thrown, based on the current available memory.
        /// </summary>
        /// <param name="maxNumber"></param>
        /// <returns></returns>
        private List<long> SieveOfEratostenes(int maxNumber)
        {
            Int64[] result = new Int64[maxNumber + 1];
            HashSet<Int64> nonPrimes = new HashSet<Int64>();

            for (Int64 i = 2; i < maxNumber + 1; i++)
                result[i - 2] = i;

            for (Int64 i = 0; i < result.Length; i++)
            {

                int p = 2;
                if (!nonPrimes.Contains(result[i]))
                {
                    while (p <= maxNumber)
                    {
                        Int64 x = result[i] * p;
                        p++;

                        if (x <= maxNumber && !nonPrimes.Contains(x))
                        {
                            nonPrimes.Add(x);
                        }
                    }
                }
            }

            var finalResult = result.Except(nonPrimes);

            Console.WriteLine();

            foreach (int elem in finalResult)
            {
                Console.Write(elem + ", ");
            }
            Console.ReadLine();
            return finalResult.ToList();
        }
    }
}
