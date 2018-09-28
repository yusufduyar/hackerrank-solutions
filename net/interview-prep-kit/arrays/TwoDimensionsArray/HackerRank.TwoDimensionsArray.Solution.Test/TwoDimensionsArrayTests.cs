using NUnit.Framework;
using HackerRank.TwoDimensionsArray.Solution;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class TwoDimensionsArrayTests
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
            int[,] arr = new int[,]{
                {-9, -9, -9,  1, 1, 1},
                { 0, -9,  0,  4, 3, 2},
                {-9, -9, -9,  1, 2, 3},
                { 0,  0,  8,  6, 6, 0},
                { 0,  0,  0, -2, 0, 0},
                { 0,  0,  1,  2, 4, 0 }
            };
            Assert.AreEqual(28, solution.hourglassSum(arr));
        }

        [Test]
        public void Test2()
        {
            int[,] arr = new int[,]{
                {1, 1, 1, 0, 0, 0},
                {0, 1, 0, 0, 0, 0},
                {1, 1, 1, 0, 0, 0},
                {0, 0, 2, 4, 4, 0},
                {0, 0, 0, 2, 0, 0},
                {0, 0, 1, 2, 4, 0 }
            };
            Assert.AreEqual(19, solution.hourglassSum(arr));
        }
    }
}