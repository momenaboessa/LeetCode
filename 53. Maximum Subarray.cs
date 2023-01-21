public class Solution {
    public int MaxSubArray(int[] nums)
    {
			var maxSum = Int32.MinValue;
        if (nums != null && nums.Length > 0)
        {
            var temp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > temp + nums[i])
                    temp = nums[i];
                else
                    temp += nums[i];
                maxSum = Math.Max(temp, maxSum);
            }
        }
        return maxSum;
    }
}
