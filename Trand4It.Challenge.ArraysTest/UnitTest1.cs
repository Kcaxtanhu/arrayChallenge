using System;
using System.Linq;
using System.Collections.Generic;
using Xunit;
using Trend4It.Challenge.Arrays;

namespace Trend4It.Challenge.ArraysTest
{
    public class UnitTest1
    {
        [Fact]
        public void CheckCompletePairsCount()
        {
            var numbers = new int[] { 1, 9, 0, 3, 4, 5, 6, 2, 9 };
            var pairs = new List<Tuple<int, int>>() {
                new Tuple<int, int>(1, 1), new Tuple<int, int>(9, 1),
                new Tuple<int, int>(9, 9), new Tuple<int, int>(9, 3),
                new Tuple<int, int>(9, 9), new Tuple<int, int>(3, 1),
                new Tuple<int, int>(3, 3), new Tuple<int, int>(4, 1),
                new Tuple<int, int>(4, 4), new Tuple<int, int>(4, 2),
                new Tuple<int, int>(5, 1), new Tuple<int, int>(5, 5),
                new Tuple<int, int>(6, 1), new Tuple<int, int>(6, 3),
                new Tuple<int, int>(6, 6), new Tuple<int, int>(6, 2),
                new Tuple<int, int>(2, 1), new Tuple<int, int>(2, 2),
                new Tuple<int, int>(9, 1), new Tuple<int, int>(9, 9),
                new Tuple<int, int>(9, 3), new Tuple<int, int>(9, 9)
            };

            Assert.True(pairs.Count == ArrayWorker.CheckDivisible(numbers).Count);

        }

        [Fact]
        public void CheckCompletePairsFirstElement()
        {
            var numbers = new int[] { 1, 9, 3, 4, 5, 6, 2, 9 };
            var pairs = new List<Tuple<int, int>>() {
                new Tuple<int, int>(1, 1), new Tuple<int, int>(9, 1),
                new Tuple<int, int>(9, 9), new Tuple<int, int>(9, 3),
                new Tuple<int, int>(9, 9), new Tuple<int, int>(3, 1),
                new Tuple<int, int>(3, 3), new Tuple<int, int>(4, 1),
                new Tuple<int, int>(4, 4), new Tuple<int, int>(4, 2),
                new Tuple<int, int>(5, 1), new Tuple<int, int>(5, 5),
                new Tuple<int, int>(6, 1), new Tuple<int, int>(6, 3),
                new Tuple<int, int>(6, 6), new Tuple<int, int>(6, 2),
                new Tuple<int, int>(2, 1), new Tuple<int, int>(2, 2),
                new Tuple<int, int>(9, 1), new Tuple<int, int>(9, 9),
                new Tuple<int, int>(9, 3), new Tuple<int, int>(9, 9)
            };

            Assert.True(pairs.FirstOrDefault().Item1 == ArrayWorker.CheckDivisible(numbers).FirstOrDefault().Item1);

        }

        [Fact]
        public void CheckPairsCount()
        {
            var numbers = new int[] { 1, 9, 3, 4, 5, 6, 2, 9 };
            var pairs = new HashSet<Tuple<int, int>>() {
                new Tuple<int, int>(1, 1), new Tuple<int, int>(9, 1),
                new Tuple<int, int>(9, 9), new Tuple<int, int>(9, 3),
                new Tuple<int, int>(3, 1), new Tuple<int, int>(3, 3),
                new Tuple<int, int>(4, 1), new Tuple<int, int>(4, 4),
                new Tuple<int, int>(4, 2), new Tuple<int, int>(5, 1),
                new Tuple<int, int>(5, 5), new Tuple<int, int>(6, 1),
                new Tuple<int, int>(6, 3), new Tuple<int, int>(6, 6),
                new Tuple<int, int>(6, 2), new Tuple<int, int>(2, 1),
                new Tuple<int, int>(2, 2)
            };

            Assert.True(pairs.Count == ArrayWorker.CheckNotRepeatedDivisible(numbers).Count);

        }

        [Fact]
        public void CheckPairsFirstElement()
        {
            var numbers = new int[] { 1, 9, 3, 4, 5, 6, 2, 9 };
            var pairs = new HashSet<Tuple<int, int>>() {
                new Tuple<int, int>(1, 1), new Tuple<int, int>(9, 1),
                new Tuple<int, int>(9, 9), new Tuple<int, int>(9, 3),
                new Tuple<int, int>(3, 1), new Tuple<int, int>(3, 3),
                new Tuple<int, int>(4, 1), new Tuple<int, int>(4, 4),
                new Tuple<int, int>(4, 2), new Tuple<int, int>(5, 1),
                new Tuple<int, int>(5, 5), new Tuple<int, int>(6, 1),
                new Tuple<int, int>(6, 3), new Tuple<int, int>(6, 6),
                new Tuple<int, int>(6, 2), new Tuple<int, int>(2, 1),
                new Tuple<int, int>(2, 2)
            };

            Assert.True(pairs.FirstOrDefault().Item1 == ArrayWorker.CheckNotRepeatedDivisible(numbers).FirstOrDefault().Item1);

        }

        [Fact]
        public void CheckCompletePairsFirstThrowable()
        {
            Assert.Throws<Exception>(() => ArrayWorker.CheckDivisible(null));
        }

        [Fact]
        public void CheckPairsFirstThrowable()
        {
            Assert.Throws<Exception>(() => ArrayWorker.CheckNotRepeatedDivisible(null));
        }


    }
}
