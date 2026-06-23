public class Solution {
    public int NumDecodings(string s)
    {
        int[]memo = new int[s.Length];
        Array.Fill(memo,-1);
        return DP(0,s,memo);
    }
    int DP(int i , string s , int[]memo )
    {
        if(i >= s.Length )return 1; 
        
        if(s[i] == '0')return 0 ;

        if(memo[i] != -1)return memo[i];

        memo[i] = DP(i+1 , s , memo);

        if( i < s.Length-1 && int.Parse($"{s[i]}{s[i + 1]}") <= 26 )
            memo[i] += DP(i+2 , s , memo);

        return memo[i];

    }
 
}