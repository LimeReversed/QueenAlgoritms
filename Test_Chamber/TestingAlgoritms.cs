using NUnit.Framework;
using Algoritmer;
using System.Collections.Generic;
using System.Diagnostics;

namespace Test_Chamber
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetLargestOddSum_TestingFirstExample_ReturnsCorrectResult()
        {
            List<int> list = new List<int> { 19, 2, 42, 18 };
            int result = Program.GetLargestOddSum(list);
            Assert.AreEqual(61, result);
        }

        [Test]
        public void GetLargestOddSum_TestingSecondExample_ReturnsCorrectResult()
        {
            List<int> list = new List<int> { 61, 32, 51 };
            int result = Program.GetLargestOddSum(list);
            Assert.AreEqual(93, result);
        }

        [Test]
        public void RemoveSequencesOfFour_TestingFirstExample_ReturnsCorrectResult()
        {
            string sequence = "ffdttttyy";
            string result = Program.RemoveSequencesOfFour(sequence);
            Debug.WriteLine(result);
            Assert.AreEqual("ffdtttyy", result);
        }

        [Test]
        public void RemoveSequencesOfFour_TestingSecondExample_ReturnsCorrectResult()
        {
            string sequence = "iiikigggg";
            string result = Program.RemoveSequencesOfFour(sequence);
            Debug.WriteLine(result);
            Assert.AreEqual("iiikiggg", result);
        }
    }
}