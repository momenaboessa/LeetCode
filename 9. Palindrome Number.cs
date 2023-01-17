public class Solution {
    public bool IsPalindrome(int x)
    {
        var stringNumber = x.ToString();

        for (int i = 0; i < stringNumber.Length; i++)
        {
            if (stringNumber[i] != stringNumber[stringNumber.Length - (1 + i)])
            {
                return false;
            }
        }
        return true;
    }
}
