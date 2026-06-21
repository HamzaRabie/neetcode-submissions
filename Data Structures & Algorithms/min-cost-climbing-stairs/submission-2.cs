public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int n = cost.Length;
        int[] vis = new int[n+1]; 
        Array.Fill(vis,-1);

        vis[n] = 0;
        vis[n-1] = cost[n-1];

        for(int i=n-2 ; i>=0 ; i--)
        {
            vis[i] = Math.Min( vis[i+1] , vis[i+2] ) + cost[i];
        }

        return Math.Min(vis[0], vis[1]);
    }
   
}