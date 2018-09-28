using NUnit.Framework;
using HackerRank.CountingValleys.Solution;
using System;

namespace Tests
{
    public class CountingValleysTests
    {
        private Solution solution;

        [SetUp]
        public void Setup()
        {
            solution = new Solution();
        }
        [Test]
        public void countValleys_should_return_2()
        {
            var totalStepsCount = 12;
            var path = "DDUUDDUDUUUD";
            var expectedValleyCount = 2;

            var result = solution.countValleys(totalStepsCount, path);

            Assert.AreEqual(expectedValleyCount, result);
        }

        [Test]
        public void countValleys_should_return_1()
        {
            var totalStepsCount = 8;
            var path = "UDDDUDUU";
            var expectedValleyCount = 1;

            var result = solution.countValleys(totalStepsCount, path);

            Assert.AreEqual(expectedValleyCount, result);
        }

        [Test]
        public void countValleys_should_return_0()
        {
            var totalStepsCount = 10;
            var path = "UDUUUDUDDD";
            var expectedValleyCount = 0;

            var result = solution.countValleys(totalStepsCount, path);

            Assert.AreEqual(expectedValleyCount, result);
        }


        [Test]
        public void countValleys_should_throw_exception_if_totalStepsCount_and_path_char_count_not_equal()
        {
            var totalStepsCount = 2;
            var path = "UDDDUDUU";

            Assert.Throws<ArgumentException>(() => solution.countValleys(totalStepsCount, path));
        }
    }
}