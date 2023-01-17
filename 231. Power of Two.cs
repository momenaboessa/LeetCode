public class Solution {
    public bool IsPowerOfTwo(int n)
    {
        while (n % 2 == 0 && n != 0)
        {
            n /= 2;
        }
        return n == 1 ? true : false;
    }
}
