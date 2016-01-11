using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace InterviewFun.Sorting
{
	/// <summary>
	/// A class that performs bubble sorts.
	/// </summary>
	/// <typeparam name="T">The type of elements.</typeparam>
	public class YourSolutionBubbleSorter<T> : Sorter<T>
			where T : IComparable<T>
	{
		#region Sorter methods
		/// <summary>
		/// Sorts a list using the bubble sort algorithm.
		/// </summary>
		/// <param name="list">A list of elements to sort.</param>
		/// <returns>The list of elements sorted.</returns>
		override public IList<T> Sort(IList<T> list)
		{
			// TODO: Try your solution here. Running the TestYourBubbleSorterSolution test 
			throw new NotImplementedException();
		}
		#endregion
	}
}
