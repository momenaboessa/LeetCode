public class Solution {
    public int LengthOfLongestSubstring(string s)
		{
			var UniqueChars = new Dictionary<char, int>();
			int len = s.Length;
			int i = 0;
			int j = 0;
			int max = 0;

			while (j < len)
			{
				if (UniqueChars.ContainsKey(s[j]))
				{
					UniqueChars.Remove(s[i]);
					i++;
				}
				else
				{
					UniqueChars.Add(s[j], j);
					max = Math.Max(max, UniqueChars.Count());
					j++;
				}
			}
			return max;
		}
}
