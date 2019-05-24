using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Trend4It.Challenge.Arrays
{
    public class ArrayWorker
    {
        public static List<Tuple<int,int>> CheckDivisible(int[] numbersList)
        {
            if (numbersList == null || numbersList.Length < 1 || !numbersList.Any())
                throw new Exception("The array parameter provided doesn't contain any value");

            var pairs = new List<Tuple<int, int>>();

            for (int d = 0; d < numbersList.Length; d++)
            {
                for (int i = 0; i < numbersList.Length; i++)
                {
                    try
                    {
                        if (numbersList[d] % numbersList[i] == 0 && numbersList[d] != 0)
                        {
                            Console.WriteLine($"{ numbersList[d] } div { numbersList[i] }");
                            pairs.Add(new Tuple<int, int>(numbersList[d], numbersList[i]));
                        }
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine($"Divisio on { numbersList[d] } by { numbersList[i] } ignored");
                        continue;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }

            return pairs;
        }

        public static HashSet<Tuple<int, int>> CheckNotRepeatedDivisible(int[] numbersList)
        {
            if (numbersList == null || numbersList.Length < 1 || !numbersList.Any())
                throw new Exception("The array parameter provided doesn't contain any value");

            var pairs = new HashSet<Tuple<int,int>>();

            for (int d = 0; d < numbersList.Length; d++)
            {
                for (int i = 0; i < numbersList.Length; i++)
                {
                    try
                    {
                        if (numbersList[d] % numbersList[i] == 0 && pairs.Where(p => p.Item1 == numbersList[d] && p.Item2 == numbersList[i]).Count() < 1 && numbersList[d] != 0)
                        {
                            Console.WriteLine($"{ numbersList[d] } div { numbersList[i] }");
                            pairs.Add(new Tuple<int, int>(numbersList[d], numbersList[i]));
                        }
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine($"Divisio on { numbersList[d] } by { numbersList[i] } ignored");
                        continue;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }

            return pairs;
        }
    }
}
