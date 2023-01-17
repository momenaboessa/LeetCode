public class Solution {
    public string LongestCommonPrefix(string[] strs)
		{
			if (strs.Length == 0) return String.Empty;

			var strbuilder = new StringBuilder();
			for (int index = 0; index < strs[0].Length; index++)
			{
				for (int i = 1; i < strs.Length; i++)
				{
					if (index >= strs[i].Length || strs[i][index] != strs[0][index])
					{
						return strbuilder.ToString();
					}
				}
				strbuilder.Append(strs[0][index]);
			}

			return strbuilder.ToString();
		}
}
