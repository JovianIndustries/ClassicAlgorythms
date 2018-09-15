using System;
using System.Collections.Generic;

namespace ClassicAlgorithms
{
    public class BuySellGold
    {
        int[] bestDays;

        public static void Initialize()
        {
            BuySellGold buySellGold = new BuySellGold();

            //int[] pricesGroup = new int[10000];
            //Random rnd = new Random();

            //for (int i = 0; i < pricesGroup.Length; i++)
            //{
            //    pricesGroup[i] = rnd.Next(rnd.Next(0, 100000), 10000000);
            //}

            int[] pricesGroup = new int[] { 200, 187, 167, 133, 121, 100, 70, 55, 23, 1 };

            buySellGold.bestDays = buySellGold.FindMaxOrMinDifference(pricesGroup, pricesGroup.Length);

            buySellGold.WriteResults();
        }

        int BuyDay()
        {
            return bestDays[0];
        }

        int SellDay()
        {
            return bestDays[1];
        }

        void WriteResults()
        {
            Console.WriteLine();
            Console.WriteLine("best day to buy is day " + BuyDay());
            Console.WriteLine("best day to sel is day " + SellDay());
            Console.WriteLine("profit made is " + bestDays[2]);
            Console.ReadLine();
        }

        /// <summary>
        /// Finds the best buy day and the sell day to maximeze profit or minimize loss
        /// </summary>
        /// <returns>The max or minimum difference.</returns>
        /// <param name="array">Array.</param>
        /// <param name="n">size of the array</param>
        int[] FindMaxOrMinDifference(int[] array, int n)
        {
            int maxDif = int.MinValue;
            int[] result = new int[3];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict = array.ToDictionary();

            DateTime startTime = DateTime.Now;

            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (array[j] - array[i] > maxDif)
                    {
                        maxDif = array[j] - array[i];
                        result[0] = i;
                        result[1] = j;
                        result[2] = maxDif;
                    }
                }
            }

            if (maxDif == int.MinValue)
            {
                int minDif = int.MaxValue;
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (Math.Abs(array[j] - array[i]) < minDif)
                        {
                            minDif = Math.Abs(array[j] - array[i]);
                            result[0] = i;
                            result[1] = j;
                            result[2] = minDif;
                        }
                    }
                }
            }

            DateTime endTime = DateTime.Now;
            Console.WriteLine();
            Console.WriteLine("Execution time: " + (endTime - startTime).TotalSeconds);

            return result;
        }
    }

    public static class Extensions
    {
        /// <summary>
        /// Simple array to Dictionary conversion 
        /// </summary>
        /// <returns>The dictionary.</returns>
        /// <param name="array">Array.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        public static Dictionary<int, T> ToDictionary<T>(this T[] array)
        {
            Dictionary<int, T> dict = new Dictionary<int, T>();

            for (int i = 0; i < array.Length; i++)
            {
                dict.Add(i, array[i]);
            }
            return dict;
        }
    }
}