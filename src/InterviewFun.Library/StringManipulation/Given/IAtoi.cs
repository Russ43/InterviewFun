using System;
using System.Diagnostics;

namespace InterviewFun.StringManipulation
{
	/// <summary>
	/// An interface that defines the atoi method.
	/// </summary>
	public interface IAtoi
	{
		#region methods
		/// <summary>
		/// Converts a string to an integer.
		/// </summary>
		/// <param name="str">A string representation of an integer.</param>
		/// <returns>The integer.</returns>
		int Atoi(string str);
		#endregion
	}
}
