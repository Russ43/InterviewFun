using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace InterviewFun.LinkedLists
{
	/// <summary>
	/// A static class with an extension method for reversing a <see cref="LinkedList"/>.
	/// </summary>
	static public class LinkedListReverseExtension
	{
		static public void Reverse<T>(this LinkedList<T> linkedList)
		{
			Node<T> previousNode = null;
			Node<T> currentNode = linkedList.HeadNode;
			while(currentNode != null)
			{
				Node<T> nextNode = currentNode.Next;

				currentNode.Next = previousNode;

				previousNode = currentNode;
				currentNode = nextNode;
			}

			linkedList.HeadNode = previousNode;
		}
	}
}
