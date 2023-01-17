public class Solution {
    public bool DetectCapitalUse(string word)
		{
			if (word.Length > 1)
			{
				if (char.IsUpper(word[0]) && char.IsUpper(word[1]))
				{
					for (int i = 2; i < word.Length; i++)
					{
						if (char.IsLower(word[i]))
							return false;
					}
				}
				else
				{
					for (int i = 1; i < word.Length; i++)
					{
						if (char.IsUpper(word[i]))
							return false;
					}
				}
			}
			return true;
		}
}
