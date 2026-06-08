public class Solution {

    public string Encode(IList<string> strs) {
        string res = ""; 
        for(int i = 0; i < strs.Count; i++)
        {
            res += strs[i].Length + "#" + strs[i];
        }
        return res;
    }

    public List<string> Decode(string s) {
        List<string> res = new List<string>();
        string n="";
        for(int i=0 ; i<s.Length ; i++)
        {
            while(char.IsDigit(s[i])){n+=s[i++];}
            if (s[i] == '#')
            {
                int len = int.Parse(n);
                string w="";
                for( int k=i+1;k<= i+len ; k++)
                {
                    w+=s[k];
                }
                res.Add(w);
                w="";
                n="";
                i += len;
            }
        }
        return res;
   }
}
