using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using InterviewFun.LinkedLists;
using InterviewFun.LinkedLists.Reverse;

namespace InterviewFun.UnitTests
{
	[TestClass]
	public class LinkedListTests
	{
		[TestMethod]
		public void TestReverseLinkedListSolution1()
		{
			LinkedList<int> linkedList = new Solution1LinkedList<int>();
			linkedList.Insert(1);
			linkedList.Insert(2);
			linkedList.Insert(3);
			linkedList.Insert(4);
			linkedList.Insert(5);

			linkedList.Reverse();
			Assert.AreEqual("5, 4, 3, 2, 1", linkedList.ToString());
		}

		[TestMethod]
		public void TestYourReverseLinkedListSolution()
		{
			LinkedList<int> linkedList = new YourSolutionLinkedList1<int>();
			linkedList.Insert(1);
			linkedList.Insert(2);
			linkedList.Insert(3);
			linkedList.Insert(4);
			linkedList.Insert(5);

			linkedList.Reverse();
			Assert.AreEqual("5, 4, 3, 2, 1", linkedList.ToString());
		}
	}
}
