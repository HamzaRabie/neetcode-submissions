public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char,int> v = new Dictionary<char,int>();
        int res=0 , l=0 , mostfreq = 0;
        for(int i=0 ; i<s.Length ; i++)
        {
            if(!v.ContainsKey(s[i]))
                v[s[i]] = 0;
            v[s[i]]++;


            if(v[s[i]] > mostfreq) mostfreq = v[s[i]];

            while( (i-l+1) - mostfreq > k )
            {
                v[s[l]]--;
                if(v[s[l]] == 0) v.Remove(s[l]);
                l++;
            }

            res = Math.Max(res , i-l+1);
        }
        return res;
    }
}