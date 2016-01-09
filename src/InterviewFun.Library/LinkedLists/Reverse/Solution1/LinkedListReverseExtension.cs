using System;
using System.Collections.Generic;
using System.Diagnostics;

using InterviewFun.LinkedLists;

namespace InterviewFun.LinkedLists.Reverse
{
	/// <summary>
	/// A static class with an extension method for reversing a <see cref="LinkedList"/>.
	/// </summary>
	public class Solution1LinkedList<T> : LinkedList<T>
	{
		/// <summary>
		/// Reverses a linked list.
		/// </summary>
		/// <typeparam name="T">The type of elements stored in the list.</typeparam>
		/// <param name="linkedList">The list to reverse.</param>
		public override void Reverse()
		{
			Node<T> previousNode = null;
			Node<T> currentNode = HeadNode;
			while(currentNode != null)
			{
				Node<T> nextNode = currentNode.Next;

				currentNode.Next = previousNode;

				previousNode = currentNode;
				currentNode = nextNode;
			}

			HeadNode = previousNode;
		}
	}
}
