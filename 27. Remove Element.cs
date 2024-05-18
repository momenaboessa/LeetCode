public class Solution 
{
    public int RemoveElement(int[] nums, int val) 
    {
        int k = 0; // Pointer for the next valid element position

        for (int i = 0; i < nums.Length; i++) 
        {
            if (nums[i] != val) 
            {
                nums[k] = nums[i]; // Move valid element to the front
                k++; // Increment the count of valid elements
            }
        }

        return k; // Return the number of valid elements
    }
}
