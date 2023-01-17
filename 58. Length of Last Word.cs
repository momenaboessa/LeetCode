public class Solution {
    public int LengthOfLastWord(string s) {
        var word = s.Split(" ").ToList();
        word.RemoveAll(s => s == "");
        return word.Last().Length;
    }
}
