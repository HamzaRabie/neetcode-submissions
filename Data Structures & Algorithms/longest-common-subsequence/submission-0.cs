public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        int[,] dp = new int[text1.Length,text2.Length];
        for(int r = 0; r < text1.Length; r++)
        {
            for(int c = 0; c < text2.Length; c++)
            {
                 dp[r,c] = -1;
            }
        }
        return DP(text1 , text2 , 0 , 0 , dp);
    }
    int DP(string text1, string text2, int i, int j, int[,] dp)
    {
        if( i >= text1.Length || j >= text2.Length ) return 0;

        if(dp[i,j] != -1)return dp[i,j];

        if( text1[i] == text2[j] ) return 1 + DP(text1 , text2 , i+1 , j+1 , dp);

        else dp[i,j] =  Math.Max(
            DP(text1 , text2 , i+1 , j , dp ),
            DP(text1 , text2 , i , j+1 , dp ) 
        );

        return dp[i,j];

    }
}