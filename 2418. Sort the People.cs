public class Solution {
    public string[] SortPeople(string[] names, int[] heights)
    {
        Dictionary<int, string> myDict = new Dictionary<int, string>();
        for (int i = 0; i < heights.Length; i++)
        {
            myDict.Add(heights[i], names[i]);
        }
        return myDict.OrderByDescending(x => x.Key).Select(x => x.Value).ToArray();
    }
}
