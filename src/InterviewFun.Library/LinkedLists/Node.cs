using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace InterviewFun.LinkedLists
{
	/// <summary>
	/// A generic node for a singly linked list.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Node<T>
	{
		#region constructors
		/// <summary>
		/// Creates an empty node.
		/// </summary>
		public Node()
		{
		}

		/// <summary>
		/// Creates a node with a specific value.
		/// </summary>
		/// <param name="value">The value to initialize the node to.</param>
		public Node(T value)
		{
			Value = value;
		}
		#endregion

		#region properties
		/// <summary>
		/// The value represented by this node.
		/// </summary>
		public T Value
		{
			get;
			set;
		}

		/// <summary>
		/// A "pointer" (or, more accurately in .NET, a "reference") to the next node in the list.
		/// </summary>
		public Node<T> Next
		{
			get;
			set;
		}
		#endregion

		#region object methods
		/// <summary>
		/// Returns the value of the node formatted as a string.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			if(Value != null)
				return Value.ToString();
			else
				return "(null)";
		}
		#endregion
	}
}
