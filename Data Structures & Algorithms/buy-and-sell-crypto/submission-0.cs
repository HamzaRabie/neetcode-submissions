public class Solution {
    public int MaxProfit(int[] prices) {
        int l=0 , res=0;
        for(int i=0 ; i<prices.Length ; i++)
        {
            if( prices[i] <= prices[l] )l=i;
            else
                res = Math.Max(res , prices[i] - prices[l]);
            
        }
        return res;
    }
}