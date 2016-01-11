using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace InterviewFun.Sorting
{
	/// <summary>
	/// A class that performs bubble sorts.
	/// </summary>
	/// <typeparam name="T">The type of elements.</typeparam>
	public class Solution1BubbleSorter<T> : Sorter<T>
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
			if(list == null)
				throw new ArgumentNullException("list");

			for(int i = 0; i < list.Count; ++i)
			{
				for(int j = i + 1; j < list.Count; ++j)
				{
					if(list[i].CompareTo(list[j]) > 0)
					{
						// the jth element comes before the ith element, so swap
						T temp = list[i];
						list[i] = list[j];
						list[j] = temp;
					}
				}
			}

			return list;
		}
		#endregion
	}
}
