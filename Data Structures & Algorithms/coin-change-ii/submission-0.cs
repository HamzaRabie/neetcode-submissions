public class Solution {
    public int Change(int amount, int[] coins) {
        int[,] memo = new int[coins.Length, amount + 1];

        for (int i = 0; i < coins.Length; i++)
        {
            for (int j = 0; j <= amount; j++)
            {
                memo[i, j] = -1;
            }
        }
        return DP(0,amount , coins,memo);
    }
    int DP(int i , int amount , int[] coins , int[,] memo)
    {
        if(amount == 0)return 1; 
        if(amount < 0 || i == coins.Length)return 0;

        if( memo[i,amount] != -1)return memo[i,amount];

        int res=0;
        for(int j=i ; j<coins.Length ; j++)
        {
            res += DP(j , amount - coins[j] , coins,memo);
            memo[i,amount] = res;
        }

        return memo[i,amount];
    }
}
