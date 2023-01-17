public class Solution {
    public int[] RunningSum(int[] nums)
    {
        var RunningSumList = new int[nums.Length];
        RunningSumList[0] = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            RunningSumList[i] = RunningSumList[i - 1] + nums[i];
        }
        return RunningSumList;
    }
}
