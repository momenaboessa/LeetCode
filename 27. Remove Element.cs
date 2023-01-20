public class Solution {
    public int RemoveElement(int[] nums, int val)
    {
        if (nums.Length == 0)
				return 0;

        int startingPoint = 0;

        for (int secondPoint = 0; secondPoint < nums.Length; secondPoint++)
            if (nums[secondPoint] != val)
                nums[startingPoint++] = nums[secondPoint];

        return startingPoint;
    }
}
