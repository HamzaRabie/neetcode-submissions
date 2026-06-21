class Solution {
public:
    string longestPalindrome(string s) {
        int n = s.size() , mx=0 , lef=0 , rig=0;
        string res="";
        for(int i=0 ; i<n ; i++){
            int l=i , r=i;
            
            while (l>=0 && r < n )
            {
                if(s[l] == s[r])
                {
                    l--;
                    r++;
                }else break;
            }

            if((r-1) - (l+1)  >= mx){
                mx = (r-1) - (l+1);
                lef = l+1;
                rig = r-1;
            }

            l=i , r=i+1;
            while (l>=0 && r < n )
            {
                if(s[l] == s[r])
                {
                    l--;
                    r++;
                }else break;
            }
            if((r-1) - (l+1) >= mx){
              mx = (r-1) - (l+1);
                lef = l+1;
                rig = r-1;
            }

            
            
        }
             for(int i=lef ; i<=rig ; i++){
            res+=s[i];
        }
        return res;
    }

};