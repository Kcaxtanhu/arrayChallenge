using System;
using System.Collections.Generic;
using System.Text;

namespace Trand4It.Challenge.Arrays
{
    public class ArrayWorker
    {
        public static HashSet<string> CheckDivisible(int[] numbersList)
        {
            var pairs = new HashSet<string>();

            foreach (var number in numbersList)
            {
                for (int i = 0; i < numbersList.Length; i++)
                {
                    if (number % numbersList[i] == 0)
                    {
                        Console.WriteLine($"{ number } div { numbersList[i] }");
                        pairs.Add($"{ number }-{ numbersList[i] }");
                    }
                }
            }

            return pairs;
        }

        public static HashSet<string> CheckNotRepeatedDivisible(int[] numbersList)
        {
            var pairs = new HashSet<string>();

            foreach (var number in numbersList)
            {
                for (int i = 0; i < numbersList.Length; i++)
                {
                    if (number % numbersList[i] == 0 && !pairs.Contains($"{ number }-{ numbersList[i] }"))
                    {
                        Console.WriteLine($"{ number } div { numbersList[i] }");
                        pairs.Add($"{ number }-{ numbersList[i] }");
                    }
                }
            }

            return pairs;
        }
    }
}
