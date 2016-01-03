using System;
using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewFun.UnitTests
{
	[TestClass]
	public class SortTests 
		
	{
		// methods
		[TestMethod]
		public void TestIsSortedMethod()
		{
			Assert.IsTrue(SortTests.IsSorted<int>(new int[] {}));
			Assert.IsTrue(SortTests.IsSorted<int>(new int[] { 0 }));
			Assert.IsFalse(SortTests.IsSorted<int>(new int[] { 1, 0 }));
			Assert.IsTrue(SortTests.IsSorted<int>(new int[] { 1, 2, 3, 4 }));
			Assert.IsFalse(SortTests.IsSorted<int>(new int[] { 8, 1, 2, 3, 4 }));
			Assert.IsTrue(SortTests.IsSorted<int>(new int[] { 2, 4, 6, 8 }));
			Assert.IsFalse(SortTests.IsSorted<int>(new int[] { 92, 2, 4, 6, 8 }));
			Assert.IsTrue(SortTests.IsSorted<int>(new int[] { 2, 2, 4, 4, 6, 6, 8, 8 }));
			Assert.IsFalse(SortTests.IsSorted<int>(new int[] { 3, 2, 2, 4, 4, 6, 6, 8, 8 }));
			Assert.IsTrue(SortTests.IsSorted<int>(new int[] { -9, -3, 2, 4, 6, 8, 13, 21, 34, 55, 89 }));
			Assert.IsFalse(SortTests.IsSorted<int>(new int[] { -1, -3, 2, 4, 6, 8, 13, 21, 34, 55, 89 }));

			Assert.IsTrue(SortTests.IsSorted<double>(new double[] { }));
			Assert.IsTrue(SortTests.IsSorted<double>(new double[] { 0.0 }));
			Assert.IsTrue(SortTests.IsSorted<double>(new double[] { 1.1, 2.2, 3.3, 4.4 }));
			Assert.IsTrue(SortTests.IsSorted<double>(new double[] { 2.0, 4.0, 6.0, 8.0 }));
			Assert.IsTrue(SortTests.IsSorted<double>(new double[] { 2.1, 2.1, 4.2, 4.2, 6.3, 6.3, 8.4, 8.4 }));
			Assert.IsTrue(SortTests.IsSorted<double>(new double[] { -9.643234, -3.181809765, 2.4242, 4.64071046, 
				6.13, 8.6, 13.1315927, 21.1, 34.04, 55.98, 89.6 }));
			Assert.IsFalse(SortTests.IsSorted<double>(new double[] { 0.0, -9.643234, -3.181809765, 2.4242, 4.64071046, 
				6.13, 8.6, 13.1315927, 21.1, 34.04, 55.98, 89.6 }));

			Assert.IsTrue(SortTests.IsSorted<char>(new char[] { 'A', 'B', 'C' }));
			Assert.IsTrue(SortTests.IsSorted<char>(new char[] { 'D', 'E', 'F' }));
			Assert.IsTrue(SortTests.IsSorted<char>(new char[] { 'A', 'B', 'C', 'a', 'b', 'c' }));
			Assert.IsTrue(SortTests.IsSorted<char>(new char[] { '#', '$', '%' }));

			Assert.IsFalse(SortTests.IsSorted<char>(new char[] { 'A', 'C', 'B', 'C' }));
			Assert.IsFalse(SortTests.IsSorted<char>(new char[] { 'F', 'D', 'G', 'E', 'F' }));
			Assert.IsFalse(SortTests.IsSorted<char>(new char[] { 'A', 'a', 'B', 'b', 'C', 'c' }));
		}


		// private methods
		static private bool IsSorted<T>(IEnumerable<T> sequence)
			where T : IComparable<T>
		{
			// assume true (which also holds for the trivial empty sequence case and single item case) until proven otherwise
			bool isSorted = true;
			
			IEnumerator<T> enumerator = sequence.GetEnumerator();
			bool hasAtLeastOneItem = enumerator.MoveNext();
			if(hasAtLeastOneItem)
			{ 
				T previousItem = enumerator.Current;
				while(enumerator.MoveNext())
				{
					T currentItem = enumerator.Current;
					if(!(currentItem.CompareTo(previousItem) >= 0))
					{
						// the current item is NOT greater-than-or-equal-to the previous item, so the sequence is NOT sorted
						isSorted = false;
						break;
					}

					previousItem = currentItem;
				}
			}

			return isSorted;
		}
	}
}

