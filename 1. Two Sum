public class Solution {
    public int[] TwoSum(int[] nums, int target)
		{
			var d = new Dictionary<int,int>();
			for (int i = 0; i < nums.Length; i++)
			{
				var v = target - nums[i];
				if (d.ContainsValue(v))
				{
					return new int[] { d.Where(a => a.Value == v).First().Key,i};
				}
				else
				{
					d.Add(i, nums[i]);
				}
			}
			return null;
		}
}
