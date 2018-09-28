using NUnit.Framework;
using HackerRank.SockMerchant.Solution;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class SockMerchantTests
    {
        private Solution solution;
        [SetUp]
        public void Setup()
        {
            solution = new Solution();
        }

        [Test]
        public void sockMerchant_Should_Return_3()
        {
            var numberOfSocks = 9;
            var colorsOfEach = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            var expectedResult = 3;

            var result = solution.sockMerchant(numberOfSocks, colorsOfEach);

            Assert.AreEqual(expectedResult, result);
        }


        [Test]
        public void sockMerchant_Should_Return_4()
        {
            var numberOfSocks = 10;
            var colorsOfEach = new int[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };
            var expectedResult = 4;

            var result = solution.sockMerchant(numberOfSocks, colorsOfEach);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void sockMerchant_Should_Return_0()
        {
            var numberOfSocks = 2;
            var colorsOfEach = new int[] { 1, 2 };
            var expectedResult = 0;

            var result = solution.sockMerchant(numberOfSocks, colorsOfEach);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void sockMerchant_should_throw_exception_when_numberOfSocks_and_colorsOfEach_count_is_different()
        {
            var numberOfSocks = 3;
            var colorsOfEach = new int[] { 1, 2 };

            Assert.Throws<ArgumentException>(() => solution.sockMerchant(numberOfSocks, colorsOfEach));
        }
    }
}