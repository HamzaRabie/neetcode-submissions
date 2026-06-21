public class Solution {
    public int ClimbStairs(int n) {    
        int[] vis = new int[n+1];
        Array.Fill(vis,-1); 
        return DP(n , vis);
    }
    int DP(int n , int[] vis)
    {
        if(n < 0)return 0;

        if(n == 0)return 1;

        if(vis[n] != -1)return vis[n];

        vis[n] =  DP(n-1 , vis) + DP(n-2 , vis);
        return vis[n];
    }
}