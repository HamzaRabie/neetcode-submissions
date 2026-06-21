public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int[] vis = new int[cost.Length+1]; 
        Array.Fill(vis,-1);

        int Zero = DP(0,cost , vis);
        Array.Fill(vis,-1);
        int One= DP(1,cost,vis);

        return Math.Min(Zero , One);
    }
    int DP(int i , int[]cost , int[] vis)
    {
        if(i >= cost.Length )return 0;

        if(vis[i] != -1)return vis[i];

        vis[i] =  cost[i] + Math.Min( DP(i+1 , cost , vis) , DP(i+2 , cost , vis) );

        return vis[i];
    }
}
