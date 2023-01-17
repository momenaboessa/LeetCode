public class Solution {
    public int HammingWeight(uint n) {
       var count = 0;
            for (int i = 0; i < 32; i++)             
            {                 
                if (((n >> i) & 1) == 1)
                {
                    count++;
                }
            }

            return count;
    }
}
