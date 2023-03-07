using System.Linq;
using coolOrange_CandidateChallenge;
using NUnit.Framework;

namespace coolOrange_CandidateChallengeTest
{
	[TestFixture]
	public class ArrayTests
	{
		[Test]
		public void FindMaxValue_returns_the_maximum_value_between_two_positions()
		{
			var array = new[] { 10, 20, 100, 40, 50 };
			Assert.AreEqual(100, Array.FindMaxValue(array, 0, 4));
			Assert.AreEqual(50, Array.FindMaxValue(array, 4, 4));
			Assert.AreEqual(20, Array.FindMaxValue(array, 0, 1));
		}

		[Test]
		public void FindMinValuePosition_returns_the_position_of_the_minimum_value_between_two_positions()
		{
			var array = new[] { 10, 20, 100, 20, 40, 1 };
			Assert.AreEqual(5, Array.FindMinPosition(array, 0, 5));
			Assert.AreEqual(0, Array.FindMinPosition(array, 0, 1));
			Assert.AreEqual(1, Array.FindMinPosition(array, 1, 3));
		}

		[Test]
		public void Swap_swaps_the_values_of_passed_positions_in_the_array()
		{
			var array1 = new int[] { 1, 2, 3, 4 };
			Array.Swap(array1, 0, 3);
			Assert.AreEqual(new int[] { 4, 2, 3, 1 }, array1);

			var array2 = new int[] { 3, 2, 6, 9 };
			Array.Swap(array2, 1, 2);
			Assert.AreEqual(new int[] { 3, 6, 2, 9 }, array2);
		}

		[Test]
		public void ShiftLeftByOne_shifts_all_values_one_position_two_the_left_between_two_positions()
		{
			var array = new int[] { 1, 2, 5, 3, 7, 9, 10 };
			Array.ShiftLeftByOne(array, 0, 5);
			Assert.AreEqual(new int[] { 2, 5, 3, 7, 1, 9, 10 }, array);
		}

		[Test]
		public void CreateRandomArray_returns_array_with_passed_size_and_random_values_between_min_and_max()
		{
			var minValue = 5;
			var maxValue = 20;
			var randomArray = Array.CreateRandomArray(10, minValue, maxValue);

			Assert.AreEqual(10, randomArray.Length);
			Assert.IsTrue(randomArray.All(value => value >= minValue));
			Assert.IsTrue(randomArray.All(value => value <= maxValue));
		}

		[Test]
		public void CreateRandomMatrix_returns_a_two_dimensional_array_with_rows_and_columns_of_random_elements_with_values_between_min_and_max()
		{
			var rows = 5; var columns = 6;
			var minValue = 0; var maxValue = 20;
			var randomMatrix = Array.CreateRandomMatrix(rows, columns, minValue, maxValue);

			Assert.AreEqual(5, randomMatrix.GetLength(0));
			Assert.AreEqual(6, randomMatrix.GetLength(1));
			Assert.IsTrue(maxValue >= randomMatrix.Cast<int>().Max());
			Assert.IsTrue(minValue <= randomMatrix.Cast<int>().Min());
		}

		[Test]
		public void CopyArray_returns_a_two_dimensional_array_with_the_original_and_the_copy_of_the_array()
		{
			var array = new[] { 1, 2, 10, 0, 2, 7 };
			var expectedResult = new [,]
			{
				{ 1, 2, 10, 0, 2, 7 },
				{ 1, 2, 10, 0, 2, 7 }
			};

			Assert.AreEqual(expectedResult, Array.CopyArray(array));
		}

		[Test]
		public void FindInSortedArray_returns_position_of_the_passed_number()
		{
			var array = new[] { 0, 1, 2, 2, 3, 5, 7, 7, 9, 10 };
			Assert.AreEqual(0, Array.FindInSortedArray(array, 0));
			Assert.AreEqual(5, Array.FindInSortedArray(array, 5));
			Assert.AreEqual(9, Array.FindInSortedArray(array, 10));
		}
	}
}