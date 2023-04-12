public class Solution {
    public int PivotIndex(int[] nums)
        {
            int total = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                total += nums[i];
            }
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (sum * 2 + nums[i] == total)
                {
                    return i;
                }
                sum += nums[i];
            }
            return -1;
        }
}
