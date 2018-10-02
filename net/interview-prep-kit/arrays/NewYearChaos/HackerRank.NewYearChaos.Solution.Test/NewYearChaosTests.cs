using NUnit.Framework;
using HackerRank.NewYearChaos.Solution;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class NewYearChaosTests
    {
        private Solution solution;
        [SetUp]
        public void Setup()
        {
            solution = new Solution();
        }

        [Test]
        public void Test1()
        {
            var currentQueue = new int[]{2,1,5,3,4};
            
            var expectedBribeCount = "3";

            var actualBribeCount = solution.minimumBribes(currentQueue);

            Assert.AreEqual(expectedBribeCount,actualBribeCount);
        }

        [Test]
        public void Test2()
        {
            var currentQueue = new int[]{2,5,1,3,4};
            var expectedBribeCount =  "Too chaotic";

            var actualBribeCount = solution.minimumBribes(currentQueue);

            Assert.That(actualBribeCount, Is.EqualTo(expectedBribeCount));
        }

                [Test]
        public void Test3()
        {
            var currentQueue = new int[]{5, 1, 2, 3, 7, 8, 6, 4};
            var expectedBribeCount =  "Too chaotic";

            var actualBribeCount = solution.minimumBribes(currentQueue);

            Assert.That(actualBribeCount, Is.EqualTo(expectedBribeCount));
        }

                [Test]
        public void Test4()
        {
            var currentQueue = new int[]{1, 2, 5, 3, 7, 8, 6, 4};
            
            var expectedBribeCount = "7";

            var actualBribeCount = solution.minimumBribes(currentQueue);

            Assert.AreEqual(expectedBribeCount,actualBribeCount);
        }
    }
}