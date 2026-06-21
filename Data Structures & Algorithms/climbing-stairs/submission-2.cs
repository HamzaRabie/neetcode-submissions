public class Solution {
    public int ClimbStairs(int n) {    
        int[] vis = new int[n+1];
        Array.Fill(vis,-1); 

        if(n < 2)return n;
        //n=2 , 1 => 1 , 0 => 1+1 , 2 

        vis[n] = 0;
        vis[n-1] = 1;
        vis[n-2] = 2;

        for(int i=n-3 ; i>= 0; i--)
        {
            vis[i] = vis[i+1] + vis[i+2];
        }

        return vis[0];
        
    }
    
}