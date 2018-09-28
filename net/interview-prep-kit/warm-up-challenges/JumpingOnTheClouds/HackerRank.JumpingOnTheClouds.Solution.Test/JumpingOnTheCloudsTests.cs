using HackerRank.JumpingOnTheClouds.Solution;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class JumpingOnTheCloudsTests
    {
        private Solution solution;
        [SetUp]
        public void Setup()
        {
            solution = new Solution();
        }

        [Test]
        public void cloud_numbers_must_be_binary_if_not_throws_exception()
        {
            var clouds = new int[] { 0, 2, 1, 0, 1, 0 };

            Assert.Throws<ArgumentException>(() => solution.jumpingOnClouds(clouds));
        }

        [Test]
        public void first_cloud_must_be_cumulus()
        {
            var clouds = new int[] { 1, 0, 0, 0, 1, 0 };
            Assert.Throws<ArgumentException>(() => solution.jumpingOnClouds(clouds));
        }

        [Test]
        public void last_cloud_must_be_cumulus()
        {
            var clouds = new int[] { 0, 0, 0, 0, 1, 1 };
            Assert.Throws<ArgumentException>(() => solution.jumpingOnClouds(clouds));
        }

        [Test]
        public void cloud_count_must_be_greater_than_or_equal_to_2()
        {
            var clouds = new int[] { 0 };
            Assert.Throws<ArgumentException>(() => solution.jumpingOnClouds(clouds));
        }

        [Test]
        public void cloud_count_must_be_less_than_or_equal_to_100()
        {
            var clouds = new List<int>() { 0 };
            int Min = 0;
            int Max = 2;
            Random randNum = new Random();
            var randomClouds = Enumerable.Repeat(0, 99).Select(i => randNum.Next(Min, Max)).ToList();
            clouds.AddRange(randomClouds);
            clouds.Add(0);

            Assert.Throws<ArgumentException>(() => solution.jumpingOnClouds(clouds.ToArray()));
        }

        [Test]
        public void jumpingOnClouds_should_return_2_for_00010()
        {
            var clouds = new int[] { 0, 0, 0, 1, 0 };
            var expectedShortestPathLength = 2;

            var actualPathLength = solution.jumpingOnClouds(clouds);
            Assert.AreEqual(expectedShortestPathLength, actualPathLength);
        }

        [Test]
        public void jumpingOnClouds_should_return_4_for_0010010()
        {
            var clouds = new int[] { 0, 0, 1, 0, 0, 1, 0 };
            var expectedShortestPathLength = 4;

            var actualPathLength = solution.jumpingOnClouds(clouds);
            Assert.AreEqual(expectedShortestPathLength, actualPathLength);
        }

        [Test]
        public void jumpingOnClouds_should_return_3_for_000010()
        {
            var clouds = new int[] { 0, 0, 0, 0, 1, 0 };
            var expectedShortestPathLength = 3;

            var actualPathLength = solution.jumpingOnClouds(clouds);
            Assert.AreEqual(expectedShortestPathLength, actualPathLength);
        }

        [Test]
        public void jumpingOnClouds_should_return_3_for_000100()
        {
            var clouds = new int[] { 0,0,0,1,0,0 };
            var expectedShortestPathLength = 3;

            var actualPathLength = solution.jumpingOnClouds(clouds);
            Assert.AreEqual(expectedShortestPathLength, actualPathLength);
        }
    }
}