using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using InterviewFun.LinkedLists;

namespace InterviewFun.UnitTests
{
	[TestClass]
	public class LinkedListTests
	{
		[TestMethod]
		public void TestReverseLinkedList()
		{
			LinkedList<int> linkedList = new LinkedList<int>();
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
