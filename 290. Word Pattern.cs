public class Solution {
    public bool WordPattern(string pattern, string s) {
        var wordsArray = s.Split(" ");
			if (pattern.Length == wordsArray.Length)
			{
				var wordsDictionary = new Dictionary<char, string>();
				for (int i = 0; i < pattern.Length; i++)
				{
					if (wordsDictionary.ContainsKey(pattern[i]))
					{
						if (wordsDictionary[pattern[i]] != wordsArray[i])
						{
							return false;
						}
					}
					else if (wordsDictionary.Values.Contains(wordsArray[i]))
					{
						return false;
					}
					else
					{
						wordsDictionary.Add(pattern[i], wordsArray[i]);
					}
				}
				return true;
			}
			else
			{
				return false;
			}
    }
}
