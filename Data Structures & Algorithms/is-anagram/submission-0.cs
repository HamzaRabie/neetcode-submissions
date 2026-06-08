public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] v1 = new int[27];
        int[] v2 = new int[27];

        if(s.Length != t.Length)return false;
        for(int i=0 ; i<s.Length ; i++)
        {
            v1[s[i] - 'a']++;
        }

        for(int i=0 ; i<t.Length ; i++)
        {
            v2[t[i] - 'a']++;
        }

        for(int i=0  ; i<27 ; i++)
        {
            if(v1[i] != v2[i]) return false;
        }

        return true;
    }
}