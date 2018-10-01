using NUnit.Framework;
using HackerRank.LeftRotation.Solution;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class LeftRotationTests
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
            var array = new int[] { 1, 2, 3, 4, 5 };
            var rotationCount = 4;

            var expectedRotatedArray = new int[] { 5, 1, 2, 3, 4 };

            var actualRotatedArray = solution.rotLeft(array, rotationCount);
            Assert.True(expectedRotatedArray.SequenceEqual(actualRotatedArray));
        }
        [Test]
        public void Test2()
        {
            var array = new int[] { 1, 2, 3, 4, 5 };
            var rotationCount = 2;

            var expectedRotatedArray = new int[] { 3,4,5,1,2 };

            var actualRotatedArray = solution.rotLeft(array, rotationCount);
            Assert.True(expectedRotatedArray.SequenceEqual(actualRotatedArray));
        }
    }
}