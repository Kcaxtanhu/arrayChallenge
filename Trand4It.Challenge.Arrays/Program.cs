using System;

namespace Trand4It.Challenge.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trand4It Arrays Challenge");

            var numbers = new int[] { 1, 9, 3, 4, 5, 6, 2, 9 };

            Console.WriteLine("***************** First Step *****************");
            ArrayWorker.CheckDivisible(numbers);

            Console.WriteLine();

            Console.WriteLine("***************** Second Step *****************");
            ArrayWorker.CheckNotRepeatedDivisible(numbers);

            Console.ReadKey();
        }
    }
}
