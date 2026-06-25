public class Solution {
    public int UniquePaths(int m, int n) {
      int[][] memo = new int[m][];

    for (int i = 0; i < m; i++)
    {
        memo[i] = new int[n];
        Array.Fill(memo[i], -1);
    }
        return DP(0,0,m,n,memo);
    }
    int DP(int i , int j , int m , int n , int [][] memo){
        if( i == m || j == n )return 0;

        if(i == m-1 && j == n-1)return 1;

        if(memo[i][j] != -1)return memo[i][j];

        memo[i][j] = DP(i+1 , j , m , n,memo) + DP(i , j+1 , m , n,memo );
        return memo[i][j];
    }
}