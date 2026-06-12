public class Solution {
    public string MinWindow(string s, string t)
    {
        Dictionary<char, int> Need = new Dictionary<char, int>();
        foreach(var c in t)
        {
            if(!Need.ContainsKey(c))
                Need[c] = 0;
            
            Need[c]++;
        }

        int have = 0, need = Need.Count;
        int l =0 , resLen = int.MaxValue, resStart = 0;

        Dictionary<char, int> window = new();
        for(int i=0 ; i<s.Length ; i++)
        {

            
                if(!window.ContainsKey(s[i]))
                    window.Add(s[i],0);

                window[s[i]]++;

                if (Need.ContainsKey(s[i]) && window[s[i]] == Need[s[i]])have++;

                while(have == need)
                {
                    if(i-l+1 < resLen)
                    {
                        resStart = l;
                        resLen = i-l+1;
                    }

                    window[s[l]]--;

                    if(Need.ContainsKey(s[l]) && window[s[l]] < Need[s[l]])
                        have--;

                    l++;
                }
            
        } 
        return resLen == int.MaxValue ? "" : s.Substring(resStart, resLen);
    }
}