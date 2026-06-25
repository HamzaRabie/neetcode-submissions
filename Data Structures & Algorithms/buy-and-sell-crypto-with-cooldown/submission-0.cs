
public class Solution {
    public int MaxProfit(int[] prices) {
        int[,] memo = new int[prices.Length, 2];
        for(int i = 0; i < prices.Length; i++)
        {
            memo[i,0] = int.MinValue;
            memo[i,1] = int.MinValue;
        }
        return DP(0,prices,0,memo);
    }
    int DP(int i , int[] prices , int state , int[,] memo)
    {
        if(i>=prices.Length)return 0;

        if(memo[i,state] !=int.MinValue)return memo[i,state];

        if(state == 0) 
            memo[i,state] = Math.Max( 
                DP(i+1,prices,1,memo) - prices[i], // buy
                DP(i+1,prices,0,memo)   //skip
            );
        else 
            memo[i,state] = Math.Max( 
                DP(i+2,prices,0,memo) + prices[i], //sell + cooldown
                DP(i+1 , prices , 1,memo)
        );
        
        return memo[i,state];


    }
}