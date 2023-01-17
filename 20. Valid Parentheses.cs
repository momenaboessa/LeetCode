public class Solution {
    public bool IsValid(string s)
		{
			if (s.Length % 2 != 0)
				return false;
			Stack<char> stack = new Stack<char>();

			foreach (char c in s)
			{
				if ((c == ')' && stack.Count > 0 && stack.Peek() == '(') ||
					(c == '}' && stack.Count > 0 && stack.Peek() == '{') ||
					(c == ']' && stack.Count > 0 && stack.Peek() == '['))
					stack.Pop();
				else
					stack.Push(c);
			}
			return stack.Count == 0;
		}
}
