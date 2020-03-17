using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using coolOrange_CandidateChallenge;

namespace coolOrange_CandidateChallengeTest
{
    [TestClass]
    public class MaxAscentsInArraysTest
    {
        [TestMethod]
        public void testMaxAscentsLength_00()
        {
            Assert.Equals(0, MaxAscentsInArrays.maxAscent(new int[] { }));
        }

        [TestMethod]
        public void testMaxAscentsLength_01()
        {
            Assert.Equals(1, MaxAscentsInArrays.maxAscent(new int[] { 1 }));
        }

        [TestMethod]
        public void testMaxAscentsLength_02()
        {
            Assert.Equals(2, MaxAscentsInArrays.maxAscent(new int[] { 1, 2 }));
        }

        [TestMethod]
        public void testMaxAscentsLength_03()
        {
            Assert.Equals(2, MaxAscentsInArrays.maxAscent(new int[] { 1, 2, 1 }));
        }

        [TestMethod]
        public void testMaxAscentsLength_04()
        {
            Assert.Equals(2, MaxAscentsInArrays.maxAscent(new int[] { 1, 2, 1, 2 }));
        }

        [TestMethod]
        public void testMaxAscentsLength_05()
        {
            Assert.Equals(1, MaxAscentsInArrays.maxAscent(new int[] { 4, 3, 2, 1 }));
        }

        [TestMethod]
        public void testMaxAscentsLength_06()
        {
            Assert.Equals(2, MaxAscentsInArrays.maxAscent(new int[] { 4, 3, 2, 1, 2, 1 }));
        }

        [TestMethod]
        public void testMaxAscentsLength_07()
        {
            Assert.Equals(3, MaxAscentsInArrays.maxAscent(new int[] { 2, 3, 4, 3, 2, 1, 2, 1 }));
        }

        [TestMethod]
        public void testMaxAscentsLength_08()
        {
            Assert.Equals(4, MaxAscentsInArrays.maxAscent(new int[] { 2, 3, 4, 3, 2, 1, 2, 1, 2, 3, 4 }));
        }
    }
}
