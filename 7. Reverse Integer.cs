public class Solution {
    public int Reverse(int x) {
        try
            {
                var result = 0;
                while (x != 0)
                {
                    result = checked(result * 10 + x % 10);
                    x = x / 10;
                }
                return result;
            }
            catch (Exception)
            {
                return 0;
            }
    }
}
