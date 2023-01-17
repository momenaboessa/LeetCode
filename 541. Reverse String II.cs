public class Solution {
    public string ReverseStr(string s, int k)
    {
        char[] a = s.ToCharArray();
        for (int start = 0; start < a.Length; start += 2 * k)
        {
            var i = start;
            var j = Math.Min(start + k - 1, a.Length - 1);
            while (i < j)
            {
                var tmp = a[i];
                a[i++] = a[j];
                a[j--] = tmp;
            }
        }
        return new string(a);
    }
}
