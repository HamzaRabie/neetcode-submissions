public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char,int> d = new();
        int l=0 , i=0 , res=0;
        for( ; i<s.Length ; i++)
        {
            if(!d.ContainsKey(s[i]))d.Add(s[i] , i);
            else
            {
                res = Math.Max(res , i - l);
                while( l < d[s[i]] )
                {
                    d.Remove(s[l++]);
                }
                l = d[s[i]]+1;
                d[s[i]] = i;
            }
        }
        res = Math.Max(res , i-l);
        return res;
    }
}