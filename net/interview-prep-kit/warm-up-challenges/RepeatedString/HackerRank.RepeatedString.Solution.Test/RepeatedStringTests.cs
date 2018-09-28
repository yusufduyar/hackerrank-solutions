using NUnit.Framework;
using HackerRank.RepeatedString.Solution;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class RepeatedStringTests
    {
        private Solution solution;
        [SetUp]
        public void Setup()
        {
            solution = new Solution();
        }

        [Test]
        public void repeatedString_should_count_7_a()
        {
            var expectedACount = 7;

            var actualACount = solution.repeatedString("aba", 10);
            Assert.AreEqual(expectedACount, actualACount);
        }

        [Test]
        public void repeatedString_should_count_1000000000000_a()
        {
            var expectedACount = 1000000000000;

            var actualACount = solution.repeatedString("a", 1000000000000);
            Assert.AreEqual(expectedACount, actualACount);
        }

        [Test]
        public void repeatedString_should_count_2_a()
        {
            var expectedACount = 2;

            var actualACount = solution.repeatedString("ababa", 3);
            Assert.AreEqual(expectedACount, actualACount);
        }
    }
}