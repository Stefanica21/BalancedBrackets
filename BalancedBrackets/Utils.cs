using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBrackets
{
	public class Utils
	{
		public static bool IsInputValid(string input)
		{
			if (input.All(c => "{[()]}".Contains(c)) && input != null && input != "") return true;
			return false;
		}

		public static bool AreBracketsBalanced(string input)
		{
			var stack = new Stack<char>();

			for (int i = 0; i < input.Length; i++)
			{
				if (IsOpenBracket(input[i]))
				{
					stack.Push(input[i]);
				}

				if (IsClosingBracket(input[i]))
				{
					if (stack.Count == 0) return false;
					else if (!IsMatchingBracket(stack.Pop(), input[i])) return false;
				}
			}

			if (stack.Count == 0) return true;
			else return false;

		}

		private static bool IsMatchingBracket(char firstCharacter, char secondCharacter)
		{
			if (firstCharacter == '(' && secondCharacter == ')') return true;
			if (firstCharacter == '[' && secondCharacter == ']') return true;
			if (firstCharacter == '{' && secondCharacter == '}') return true;
			return false;
		}

		private static bool IsOpenBracket(char character)
		{
			if (character == '(' || character == '[' || character == '{') return true;
			return false;
		}
		private static bool IsClosingBracket(char character)
		{
			if (character == ')' || character == ']' || character == '}') return true;
			return false;
		}
	}
}
