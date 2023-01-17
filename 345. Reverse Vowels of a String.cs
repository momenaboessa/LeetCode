public class Solution {
    public string ReverseVowels(string s) {
        var Vowels = new List<char>() { 'i', 'e', 'a', 'u', 'o', 'A', 'I', 'U', 'E', 'O' };
            var CharArray = s.ToCharArray();
            var VowelsDictionaryValues = new List<int>();
            var VowelsDictionaryChars = new List<char>();

            for(int i = 0; i < s.Length; i++)
            {
                if (Vowels.Contains(s[i]))
                {
                    VowelsDictionaryValues.Add(i);
                    VowelsDictionaryChars.Add(s[i]);
                }
            }
            VowelsDictionaryValues.Reverse();

            var counter = 0;
            for(int i = 0; i < CharArray.Length; i++)
            {
                if (Vowels.Contains(CharArray[i]))
                {
                    CharArray[VowelsDictionaryValues[counter]] = VowelsDictionaryChars[counter];
                    counter++;
                }
            }
            s = String.Join("", CharArray);
            return s;
    }
}
