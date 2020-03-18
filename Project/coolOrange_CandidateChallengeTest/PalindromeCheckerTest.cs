using Microsoft.VisualStudio.TestTools.UnitTesting;
using coolOrange_CandidateChallenge;

namespace coolOrange_CandidateChallengeTest
{
	[TestClass]
	public class PalindromeCheckerTest
	{
		[TestMethod]
		public void testIsPalindrome_True00()
		{
			Assert.IsTrue(PalindromeChecker.isPalindrome(""));
		}

		[TestMethod]
		public void testIsPalindrome_True01()
		{
			Assert.IsTrue(PalindromeChecker.isPalindrome("a"));
		}

		[TestMethod]
		public void testIsPalindrome_True02()
		{
			Assert.IsTrue(PalindromeChecker.isPalindrome("aa"));
		}

		[TestMethod]
		public void testIsPalindrome_True03()
		{
			Assert.IsTrue(PalindromeChecker.isPalindrome("aaa"));
		}

		[TestMethod]
		public void testIsPalindrome_True04()
		{
			Assert.IsTrue(PalindromeChecker.isPalindrome("radar"));
		}

		[TestMethod]
		public void testIsPalindrome_True05()
		{
			Assert.IsTrue(PalindromeChecker.isPalindrome("rats live on no evil star"));
		}

		[TestMethod]
		public void testIsPalindrome_False00()
		{
			Assert.IsFalse(PalindromeChecker.isPalindrome("ab"));
		}

		[TestMethod]
		public void testIsPalindrome_False01()
		{
			Assert.IsFalse(PalindromeChecker.isPalindrome("ab "));
		}

		[TestMethod]
		public void testIsPalindrome_False02()
		{
			Assert.IsFalse(PalindromeChecker.isPalindrome("ab a"));
		}

		[TestMethod]
		public void testIsPalindrome_False03()
		{
			Assert.IsFalse(PalindromeChecker.isPalindrome("abcab"));
		}
	}
}
