public class Solution {
    public string IntToRoman(int num)
		{
			var romans = new StringBuilder();
			var symbols = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
			var numbers = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

			for (int i = 0; i < numbers.Length; i++)
				while (num >= numbers[i])
				{
					romans.Append(symbols[i]);
					num -= numbers[i];
				}

			return romans.ToString();
		}
}
