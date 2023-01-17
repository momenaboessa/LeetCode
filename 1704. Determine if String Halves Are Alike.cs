public class Solution {
    public bool HalvesAreAlike(string s)
		{
			var sIndex = 0;
			var eIndex = s.Length - 1;
			var vowels = new HashSet<char> { 
				'a', 'e', 'i', 'u', 'o',
				'A', 'E', 'I', 'U', 'O'
			};
			var counter = 0;
			while (sIndex < eIndex)
			{
				if (vowels.Contains(s[sIndex]))
				{
					counter++;
				}
				if (vowels.Contains(s[eIndex]))
				{
					counter--;
				}
				sIndex++;
				eIndex--;
			}
			return counter == 0;
		}
}
