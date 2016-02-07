using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewFun.UnitTests
{
	static public class TestHelper
	{
		#region methods
		static public void AssertThrows(Action action, Type expectedExceptionType)
		{
			bool expectedExceptionWasThrown = false;

			try
			{
				action();
			}
			catch(Exception exception)
			{
				if(expectedExceptionType.IsAssignableFrom(exception.GetType()))
				{
					expectedExceptionWasThrown = true;
				}
				else
				{
					Assert.Fail(
						"Expected exception of type '{0}' but an exception of type '{1}' was thrown instead.",
						expectedExceptionType.FullName,
						exception.GetType().FullName
					);
				}
			}

			if(!expectedExceptionWasThrown)
			{
				Assert.Fail(
					"Expected exception of type '{0}' but no exception was thrown.",
					expectedExceptionType.FullName
				);
			}
		}
		#endregion
	}
}
