using NUnit.Framework;
using HackerRank.ArrayManipulation.Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Tests
{
    public class ArrayManipulationTests
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
            var numberOfElements = 5;
            var queries = new int[3][];
            queries[0] = new int[] { 1, 2, 100 };
            queries[1] = new int[] { 2, 5, 100 };
            queries[2] = new int[] { 3, 4, 100 };

            var expectedMaxValue = 200;

            var actualMaxValue = solution.arrayManipulation(numberOfElements, queries);

            Assert.AreEqual(expectedMaxValue, actualMaxValue);
        }

        [Test]
        public void Test2()
        {
            var numberOfElements = 10;
            var queries = new int[3][];
            queries[0] = new int[] { 1, 5, 3 };
            queries[1] = new int[] { 4, 8, 7 };
            queries[2] = new int[] { 6, 9, 1 };

            var expectedMaxValue = 10;

            var actualMaxValue = solution.arrayManipulation(numberOfElements, queries);

            Assert.AreEqual(expectedMaxValue, actualMaxValue);
        }

        [Test]
        public void Test3()
        {
            var numberOfElements = 10;
            var queries = new int[4][];
            queries[0] = new int[] { 2, 6, 8 };
            queries[1] = new int[] { 3, 5, 7 };
            queries[2] = new int[] { 1, 8, 1 };
            queries[3] = new int[] { 5, 9, 15 };

            var expectedMaxValue = 31;

            var actualMaxValue = solution.arrayManipulation(numberOfElements, queries);

            Assert.AreEqual(expectedMaxValue, actualMaxValue);
        }

        [Test]
        public void Test4()
        {
            var expectedMaxValue = 7542539201;

            var actualMaxValue = TestFromFile("input04.txt");

            Assert.AreEqual(expectedMaxValue, actualMaxValue);
        }

        [Test]
        public void Test5()
        {
            var expectedMaxValue = 2497169732;

            var actualMaxValue = TestFromFile("input07.txt");

            Assert.AreEqual(expectedMaxValue, actualMaxValue);
        }

        private long TestFromFile(string fileName)
        {
            int counter = 0;
            string line;
            int numberOfElements = 0;
            int m = 0;
            int[][] queries = null;

            StreamReader file = new StreamReader("test-inputs/" + fileName);
            while ((line = file.ReadLine()) != null)
            {
                if (counter == 0)
                {
                    string[] nm = line.Split(' ');
                    numberOfElements = Convert.ToInt32(nm[0]);
                    m = Convert.ToInt32(nm[1]);
                    queries = new int[m][];
                }
                else
                {
                    queries[counter - 1] = Array.ConvertAll(line.Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
                }

                counter++;
            }

            file.Close();

            return solution.arrayManipulation(numberOfElements, queries);
        }
    }
}