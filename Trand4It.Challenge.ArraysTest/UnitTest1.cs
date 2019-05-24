using System;
using System.Linq;
using System.Collections.Generic;
using Xunit;
using Trand4It.Challenge.Arrays;

namespace Trand4It.Challenge.ArraysTest
{
    public class UnitTest1
    {
        [Fact]
        public void CheckCompletePairsCount()
        {
            var numbers = new int[] { 1, 9, 3, 4, 5, 6, 2, 9 };
            var pairs = new HashSet<string>() {
                "1-1", "9-1", "9-9", "9-3", "9-9", "3-1", "3-3",
                "4-1", "4-4", "4-2", "5-1", "5-5", "6-1", "6-3",
                "6-6", "6-2", "2-1", "2-2", "9-1", "9-9", "9-3", "9-9"
            };

            Assert.True(pairs.Count == ArrayWorker.CheckDivisible(numbers).Count);

        }

        [Fact]
        public void CheckCompletePairsFirstElement()
        {
            var numbers = new int[] { 1, 9, 3, 4, 5, 6, 2, 9 };
            var pairs = new HashSet<string>() {
                "1-1", "9-1", "9-9", "9-3", "9-9", "3-1", "3-3",
                "4-1", "4-4", "4-2", "5-1", "5-5", "6-1", "6-3",
                "6-6", "6-2", "2-1", "2-2", "9-1", "9-9", "9-3", "9-9"
            };

            Assert.True(pairs.FirstOrDefault() == ArrayWorker.CheckDivisible(numbers).FirstOrDefault());

        }

        [Fact]
        public void CheckPairsCount()
        {
            var numbers = new int[] { 1, 9, 3, 4, 5, 6, 2, 9 };
            var pairs = new HashSet<string>() {
                "1-1","9-1","9-9","9-3","3-1",
                "3-3","4-1","4-4","4-2","5-1",
                "5-5","6-1","6-3","6-6","6-2",
                "2-1","2-2"
            };

            Assert.True(pairs.Count == ArrayWorker.CheckDivisible(numbers).Count);

        }

        [Fact]
        public void CheckPairsFirstElement()
        {
            var numbers = new int[] { 1, 9, 3, 4, 5, 6, 2, 9 };
            var pairs = new HashSet<string>() {
                "1-1","9-1","9-9","9-3","3-1",
                "3-3","4-1","4-4","4-2","5-1",
                "5-5","6-1","6-3","6-6","6-2",
                "2-1","2-2"
            };

            Assert.True(pairs.FirstOrDefault() == ArrayWorker.CheckDivisible(numbers).FirstOrDefault());

        }
    }
}
