public class Solution {
    public string ReverseWords(string s)
    {
        var StringArray = s.Split();
        for (int i = 0; i < StringArray.Length; i++)
        {
            StringArray[i] = String.Join("", StringArray[i].Reverse());
        }
        s = String.Join(" ", StringArray);
        return s;
    }
}
