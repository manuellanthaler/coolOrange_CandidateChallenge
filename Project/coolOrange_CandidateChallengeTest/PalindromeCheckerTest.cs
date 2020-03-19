using coolOrange_CandidateChallenge;
using NUnit.Framework;

namespace coolOrange_CandidateChallengeTest
{
	[TestFixture]
	public class PalindromeCheckerTest
	{
		[Test]
		public void IsPalindrome_passing_empty_returns_true()
		{
			Assert.IsTrue(PalindromeChecker.IsPalindrome(""));
		}

		[Test]
		public void IsPalindrome_passing_single_character_returns_true()
		{
			Assert.IsTrue(PalindromeChecker.IsPalindrome("a"));
		}

		[Test]
		[TestCase("aa")]
		[TestCase("aaa")]
		[TestCase("radar")]
		[TestCase("rats live on no evil star")]
		public void IsPalindrome_passing_a_palindrome_phrase_returns_true(string phrase)
		{
			Assert.IsTrue(PalindromeChecker.IsPalindrome(phrase));
		}

		[Test]
		[TestCase("ab")]
		[TestCase("ab ")]
		[TestCase("ab a")]
		[TestCase("abcab")]
		public void IsPalindrome_passing_no_palindrome_phrase_returns_false(string input)
		{
			Assert.IsFalse(PalindromeChecker.IsPalindrome(input));
		}
	}
}
