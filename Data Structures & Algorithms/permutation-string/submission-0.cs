public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int[] count1 = new int[27];
        int[] count2 = new int[27];

        for(int i=0 ; i<s1.Length ; i++)
        {
            count1[s1[i] - 'a'] ++;
        }

        int l=0;
        for(int i=0 ; i< s2.Length ; i++)
        {
            count2[s2[i] - 'a']++;

            while(count1[s2[i]-'a'] < count2[s2[i]-'a'])
            {
                count2[s2[l] - 'a']--;
                l++;
            }

            if( i-l+1 == s1.Length)
            {
                bool f=true;
                for(int j=0 ; j<27 ; j++)
                {
                    if( count1[j] != count2[j] ){f=false;break;}
                }
                if(f) return true;
            }
            
        }
        return false;
    }
}