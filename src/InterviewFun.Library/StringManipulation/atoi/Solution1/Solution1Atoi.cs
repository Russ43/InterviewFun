using System;
using System.Diagnostics;

namespace InterviewFun.StringManipulation
{
	/// <summary>
	/// Subclasses <see cref="IAtoi"/> and provides a simple implementation of <see cref="IAtoi.Atoi" />.
	/// </summary>
	public class Solution1Atoi : IAtoi
	{
		#region Atoi methods
		/// <summary>
		/// Converts a string to an integer.
		/// </summary>
		/// <param name="str">A string representation of an integer.</param>
		/// <returns>The integer.</returns>
		public int Atoi(string str)
		{
			if(str == null)
				throw new ArgumentNullException();

			if(str.Length == 0)
				throw new FormatException("Empty string.");

			// special case for Int32.MinValue (Due to the way "two's complement" integers works, Int32.MinValue
			// can not be negated so the general algorithm below will not work.)
			if(str.Trim() == "-2147483648")
				return -2147483648;

			bool isNegative = false;
			bool haveFoundFirstDigit = false;
			int integer = 0;
			foreach(char c in str)
			{
				if(c >= '0' && c <= '9')
				{
					// it's a digit, so append it to our integer
					haveFoundFirstDigit = true;
					try
					{
						checked
						{
							integer *= 10;
							integer += ((int) (c - '0'));
						}
					}
					catch(OverflowException)
					{
						// the number is too big for an Int32 value type, so throw
						throw new FormatException(
							"The number will not fit in the [System.Int32.MinValue, System.Int32.MaxValue] range."
						);
					}
				}
				else if(c == '-')
				{
					// it's a minus sign, so the number is negative
					if(isNegative)
					{
						// uh oh, can't have two minus signs
						throw new FormatException("More than one minus sign.");
					}
					else if(haveFoundFirstDigit)
					{
						// uh oh, can't have a minus sign in the middle of the number
						throw new FormatException("Minus sign found after first digit.");
					}
					isNegative = true;
				}
				else if(char.IsWhiteSpace(c))
				{
					// ignore whitespace
				}
				else
				{
					throw new FormatException(string.Format("Illegal character '{0}' found.", c));
				}
			}

			// verify there was at least one digit
			if(!haveFoundFirstDigit)
				throw new FormatException("No digits found.");

			// negate the integer if we detected the minus sign at the beginning
			if(isNegative)
			{
				if(integer == int.MaxValue)
				{
					// handle the edge case where negating Int32.MaxValue will make the integer out of range
					throw new FormatException(
						"The number will not fit in the [System.Int32.MinValue, System.Int32.MaxValue] range."
					);
				} 

				integer = -integer;
			}

			return integer;
		}
		#endregion
	}
}
