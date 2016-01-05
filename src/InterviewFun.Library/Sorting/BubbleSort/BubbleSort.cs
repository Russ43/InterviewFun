using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace InterviewFun
{
	static public class BubbleSort
	{
		static public IList<T> Sort<T>(IList<T> list)
			where T : IComparable<T>
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
	}
}
