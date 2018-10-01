using NUnit.Framework;
using HackerRank.MinimumSwaps.Solution;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class MinimumSwapsTests
    {
        private Solution solution;
        [SetUp]
        public void Setup()
        {
            solution = new Solution();
        }

        [Test]
        [TestCase(new int[] { 4, 3, 1, 2 }, 3)]
        [TestCase(new int[] { 1, 3, 5, 2, 4, 6, 8 }, 3)]
        [TestCase(new int[] { 2, 3, 4, 1, 5 }, 3)]
        public void minimumSwaps_should_return_correct(int[] unorderedNumbers, int expectedSwapCount)
        {
            var actualSwapCount = solution.minimumSwaps(unorderedNumbers);
            Assert.AreEqual(expectedSwapCount, actualSwapCount);
        }
    }
}