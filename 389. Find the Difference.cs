public class Solution {
    public char FindTheDifference(string s, string t) {
      foreach (var Char in t)
      {
          if (!(s.Count(a => a == Char) == t.Count(a => a == Char)))
          {
              return Char;
          }
      }
    return new char();
    }
}
