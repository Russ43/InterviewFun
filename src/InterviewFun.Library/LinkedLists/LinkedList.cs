using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace InterviewFun.LinkedLists
{
	/// <summary>
	/// A generic singly-linked list.
	/// </summary>
	/// <remarks>
	/// This is a class singly-linked list data structure with a <see cref="Head"/> property representing the
	/// first element in the list.
	/// </remarks>
	public class LinkedList<T> : IEnumerator<T>, IEnumerator
	{
		#region fields
		private bool _isReset; 
		#endregion

		#region constructors

		/// <summary>
		/// Creates an empty linked list.
		/// </summary>
		public LinkedList()
		{
			_isReset = true;
		}

		#endregion


		#region properties
		/// <summary>
		/// The "head" node containing the first element in the list.
		/// </summary>
		/// <remarks>If the list is empty, the head is null.</remarks>
		public Node<T> HeadNode
		{
			get;
			set;
		}
		#endregion

		#region private properties
		/// <summary>
		/// The "current" node used for iterating over elements in the list and for inserting new elements
		/// into the list.
		/// </summary>
		private Node<T> CurrentNode
		{
			get;
			set;
		}
		#endregion

		#region methods
		/// <summary>
		/// Insert an element into the list.
		/// </summary>
		/// <param name="value">The element to insert.</param>
		/// <remarks>
		/// If the list has just been reset or is empty, the element will be inserted at the beginning of the list.
		/// Otherwise, the element will be inserted right after <see cref="Current"/>.
		/// </remarks>
		public void Insert(T value)
		{
			if(_isReset)
			{
				Debug.Assert(CurrentNode == null);

				Node<T> headNode0 = HeadNode;

				HeadNode = new Node<T>(value);
				HeadNode.Next = headNode0;

				CurrentNode = HeadNode;
				_isReset = false;
			}
			else
			{
				Debug.Assert(HeadNode != null);
				Debug.Assert(CurrentNode != null);

				Node<T> newNode = new Node<T>(value);
				CurrentNode.Next = newNode;

				CurrentNode = newNode;
			}
		}
		#endregion

		#region object methods
		/// <summary>
		/// Returns the linked list as a comma-delimited string of values.
		/// </summary>
		/// <returns>The linked list as a comma-delimited string of values.</returns>
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			if(HeadNode != null)
			{
				sb.Append(HeadNode.ToString());

				Node<T> next = HeadNode.Next;
				while(next != null)
				{
					sb.AppendFormat(", {0}", next.ToString());
					next = next.Next;
				}
			}

			return sb.ToString();
		}

		#endregion


		#region IEnumerator<T> properties

		/// <summary>
		/// The value of the current node.
		/// </summary>
		public T Current
		{
			get
			{
				if(CurrentNode == null)
					throw new InvalidOperationException("No current node.");

				return CurrentNode.Value;
			}
		}
		#endregion

		#region IEnumerator properties

		/// <summary>
		/// The value of the current node.
		/// </summary>
		object IEnumerator.Current
		{
			get
			{
				return Current;
			}
		}
		#endregion
		
		#region IEnumerator methods
		void IEnumerator.Reset()
		{
			_isReset = true;
			CurrentNode = null;
		}

		public bool MoveNext()
		{
			if(_isReset)
			{
				CurrentNode = HeadNode;
				_isReset = false;
			}
			else
			{
				CurrentNode = CurrentNode.Next;
			}

			return (CurrentNode.Next != null);
		}
		#endregion

		#region IDisposable methods
		public void Dispose()
		{
			// nothing to do here
		}
		#endregion
	}
}
