using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace InterviewFun.Sorting
{
	/// <summary>
	/// A generic abstract class used to sort elements.
	/// </summary>
	/// <typeparam name="T">The type of elements.</typeparam>
	abstract public class Sorter<T>
			where T : IComparable<T>
	{
		#region abstract methods
		/// <summary>
		/// Sorts a list.
		/// </summary>
		/// <param name="list">A list of elements to sort.</param>
		/// <returns>The list of elements sorted.</returns>
		abstract public IList<T> Sort(IList<T> list);
		#endregion
	}
}
