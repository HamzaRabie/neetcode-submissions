public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char,int> c1 = new ();
        Dictionary<char,int> c2 = new ();
        string alpha = new string(t.Distinct().ToArray());

        for(int j=0 ; j<t.Length ; j++)
        {
            if(!c1.ContainsKey(t[j]))c1.Add(t[j],0);
            c1[t[j]]++;

            if (j < s.Length)
            {
                if(!c2.ContainsKey(s[j]))c2.Add(s[j],0);
                c2[s[j]]++;
            }
        }

        if( Compare(c1 , c2 , alpha)) return s.Substring(0,t.Length);

        int l=0 ,  i=t.Length, st=-1 , en=1000000;
        string res="";
        
        for( ; i<s.Length ; i++)
        {
            if(!c2.ContainsKey(s[i]))c2.Add(s[i],0);
            c2[s[i]]++;

            while(i-l+1 > t.Length)
            {
                if(c1.ContainsKey(s[l]) && c2[s[l]] <= c1[s[l]])break;
                
                c2[s[l]]--;
                if(c2[s[l]] == 0)c2.Remove(s[l]);
                l++;
            }

            if( Compare(c1 , c2 , alpha)  && (i-l+1) < en-st+1 ){st=l;en=i;}
            
        }        

        if( st==-1 && en== 1000000) return res;

        while(st <= en){res+=s[st++];}
        return res;
        
    }
    bool Compare(Dictionary<char,int> c1 , Dictionary<char,int> c2 , string alpha)
    {
        for(int j=0 ; j<alpha.Length ; j++)
        {
            if( c2.ContainsKey(alpha[j]) && c2[alpha[j]] >= c1[alpha[j]] )continue;
            else return false;
        }
        return true;
    }
}
