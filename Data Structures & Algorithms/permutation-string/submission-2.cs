public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int[] count1 = new int[27];
        int[] count2 = new int[27];

        for(int i=0 ; i<s1.Length ; i++)
        {
            count1[s1[i] - 'a'] ++;
            if(i < s2.Length)
                count2[s2[i] - 'a'] ++;
        }
        int l=0;
        for(int i=s1.Length ; i<s2.Length ; i++)
        {
            if(Compare(count1,count2)) return true;

            count2[s2[l++] - 'a']--;
            
            count2[s2[i] - 'a']++;
         
        }
        return Compare(count1,count2);
        
    }
    bool Compare(int[] count1 , int[] count2)
    {
         for(int j=0 ; j<27 ; j++)
        {
            if( count1[j] != count2[j] )return false;
        }
        return true;
    }
}