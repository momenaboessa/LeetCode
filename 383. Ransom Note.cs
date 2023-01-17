public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        var UniqueChars = ransomNote.ToCharArray().Distinct().ToArray();
        foreach (var Char in UniqueChars)
        {
            if (!(ransomNote.Count(a => a == Char) <= magazine.Count(a => a == Char)))
            {
                return false;
            }
        }
        return true;
    }
}
