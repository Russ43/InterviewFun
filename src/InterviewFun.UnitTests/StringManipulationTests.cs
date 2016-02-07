using System;
using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using InterviewFun.StringManipulation;

namespace InterviewFun.UnitTests
{
	[TestClass]
	public class StringManipulationTests
	{
		#region atoi test methods
		[TestMethod]
		public void TestSolution1Atoi()
		{
			IAtoi solution = new Solution1Atoi();
			ExecutePositiveAtoiTestCases(solution);
			ExecuteNegativeAtoiTestCases(solution);
		}

		[TestMethod]
		public void TestYourSolutionAtoi()
		{
			IAtoi solution = new YourSolutionAtoi();
			ExecutePositiveAtoiTestCases(solution);
			ExecuteNegativeAtoiTestCases(solution);
		}

		private void ExecutePositiveAtoiTestCases(IAtoi atoi)
		{
			Assert.AreEqual(0, atoi.Atoi("0"));
			Assert.AreEqual(1, atoi.Atoi("1"));
			Assert.AreEqual(123, atoi.Atoi("123"));
			Assert.AreEqual(Int32.MaxValue, atoi.Atoi("2147483647"));
			Assert.AreEqual(Int32.MinValue, atoi.Atoi("-2147483648"));
			Assert.AreEqual(-1, atoi.Atoi("-1"));
			Assert.AreEqual(-1, atoi.Atoi("    -1"));
			Assert.AreEqual(-1, atoi.Atoi("    -1  "));
			Assert.AreEqual(-1, atoi.Atoi("-1  "));
		}

		private void ExecuteNegativeAtoiTestCases(IAtoi atoi)
		{
			// null --> ArgumentNullException
			TestHelper.AssertThrows(
				() => 
				{ 
					atoi.Atoi(null); 
				}, 
				typeof(ArgumentNullException)
			);

			// empty string --> FormatException
			TestHelper.AssertThrows(
				() =>
				{
					atoi.Atoi(string.Empty);
				},
				typeof(FormatException)
			);

			// all whitespace string --> FormatException
			TestHelper.AssertThrows(
				() =>
				{
					atoi.Atoi("   ");
				},
				typeof(FormatException)
			);

			// decimals --> FormatException
			TestHelper.AssertThrows(
				() =>
				{
					atoi.Atoi("3.14");
				},
				typeof(FormatException)
			);

			// some letters string --> FormatException
			TestHelper.AssertThrows(
				() =>
				{
					atoi.Atoi("123abc");
				},
				typeof(FormatException)
			);

			// double negative string --> FormatException
			TestHelper.AssertThrows(
				() =>
				{
					atoi.Atoi("--17");
				},
				typeof(FormatException)
			);

			// out of range for Int32 --> FormatException
			TestHelper.AssertThrows(
				() =>
				{
					atoi.Atoi("123456789101112");
				},
				typeof(FormatException)
			);

			// out of range for Int32 --> FormatException
			TestHelper.AssertThrows(
				() =>
				{
					atoi.Atoi("2147483648");
				},
				typeof(FormatException)
			);

			// out of range for Int32 --> FormatException
			TestHelper.AssertThrows(
				() =>
				{
					atoi.Atoi("-2147483649");
				},
				typeof(FormatException)
			);
		}
		#endregion
	}
}
