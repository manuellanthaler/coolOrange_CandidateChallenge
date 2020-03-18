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
			Assert.AreEqual(0, MaxAscentsInArrays.maxAscent(new int[] { }));
		}

		[TestMethod]
		public void testMaxAscentsLength_01()
		{
			Assert.AreEqual(1, MaxAscentsInArrays.maxAscent(new int[] { 1 }));
		}

		[TestMethod]
		public void testMaxAscentsLength_02()
		{
			Assert.AreEqual(2, MaxAscentsInArrays.maxAscent(new int[] { 1, 2 }));
		}

		[TestMethod]
		public void testMaxAscentsLength_03()
		{
			Assert.AreEqual(2, MaxAscentsInArrays.maxAscent(new int[] { 1, 2, 1 }));
		}

		[TestMethod]
		public void testMaxAscentsLength_04()
		{
			Assert.AreEqual(2, MaxAscentsInArrays.maxAscent(new int[] { 1, 2, 1, 2 }));
		}

		[TestMethod]
		public void testMaxAscentsLength_05()
		{
			Assert.AreEqual(1, MaxAscentsInArrays.maxAscent(new int[] { 4, 3, 2, 1 }));
		}

		[TestMethod]
		public void testMaxAscentsLength_06()
		{
			Assert.AreEqual(2, MaxAscentsInArrays.maxAscent(new int[] { 4, 3, 2, 1, 2, 1 }));
		}

		[TestMethod]
		public void testMaxAscentsLength_07()
		{
			Assert.AreEqual(3, MaxAscentsInArrays.maxAscent(new int[] { 2, 3, 4, 3, 2, 1, 2, 1 }));
		}

		[TestMethod]
		public void testMaxAscentsLength_08()
		{
			Assert.AreEqual(4, MaxAscentsInArrays.maxAscent(new int[] { 2, 3, 4, 3, 2, 1, 2, 1, 2, 3, 4 }));
		}
	}
}
