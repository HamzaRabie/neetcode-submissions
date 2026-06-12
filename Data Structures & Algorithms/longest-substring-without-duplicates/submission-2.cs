public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char,int> d = new();
        int l=0 , i=0 , res=0;
        for( ; i<s.Length ; i++)
        {
            while (d.ContainsKey(s[i]))
            {
                d.Remove(s[l]);
                l++;
            }
            d.Add(s[i], i);
            res = Math.Max(res , i-l+1);
        }
        //res = Math.Max(res , i-l);
        return res;
    }
}