public class Solution {
    public string SortSentence(string s) {
        var words = s.Split();
            var Sentence = new string[words.Length];

            foreach (var word in words)
            {
                var position = (int)Char.GetNumericValue(word.Last()) - 1;
                Sentence[position] = word.Substring(0, word.Length - 1);
            }
            return String.Join(" ",Sentence);
    }
}
