public class Solution {
    public int RomanToInt(string s)
		{
			var romans = new Dictionary<char, int>();
			romans.Add('I', 1);
			romans.Add('V', 5);
			romans.Add('X', 10);
			romans.Add('L', 50);
			romans.Add('C', 100);
			romans.Add('D', 500);
			romans.Add('M', 1000);

			int sum = 0;

			for (int i = 0; i < s.Length; i++)
			{
				var currentValue = romans[s[i]];

				if (i + 1 < s.Length && currentValue < romans[s[i + 1]])
				{
					sum += romans[s[i + 1]] - currentValue;
					i++;
				}
				else
				{
					sum += currentValue;
				}				
			}
			return sum;
		}
}
