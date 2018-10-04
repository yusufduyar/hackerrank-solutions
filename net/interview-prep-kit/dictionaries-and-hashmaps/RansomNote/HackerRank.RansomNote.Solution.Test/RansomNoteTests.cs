using NUnit.Framework;
using HackerRank.RansomNote.Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.IO;

namespace Tests
{
    public class RansomNoteTests
    {
        private readonly string INPUT_PREFIX = "inputs/input";
        private readonly string OUTPUT_PREFIX = "outputs/output";

        private Solution solution;
        [SetUp]
        public void Setup()
        {
            solution = new Solution();
        }

        [Test]
        [TestCase("00")]
        [TestCase("20")]
        [TestCase("21")]
        public void TestFromInputFiles(string inputNumber)
        {
            string inputFileName = getInputFileName(inputNumber);
            string firstLine = File.ReadLines(inputFileName).Take(1).First();
            string secondLine = File.ReadLines(inputFileName).Skip(1).Take(1).First();
            string thirdLine = File.ReadLines(inputFileName).Skip(2).Take(1).First();

            string[] mn = firstLine.Split(' ');
            int magazineWordsCount = Convert.ToInt32(mn[0]);
            int noteWordsCount = Convert.ToInt32(mn[1]);
            string[] magazine = secondLine.Split(' ');
            string[] note = thirdLine.Split(' ');

            string outputFileName = getOutputFileName(inputNumber);
            string expectedOutput = File.ReadLines(outputFileName).Take(1).First();

            string actualOutput = solution.checkMagazine(magazine, note);

            Assert.That(actualOutput,Is.EqualTo(expectedOutput));
        }

        private string getInputFileName(string inputNumber) => $"{INPUT_PREFIX}{inputNumber}.txt";
        private string getOutputFileName(string inputNumber) => $"{OUTPUT_PREFIX}{inputNumber}.txt";

    }
}