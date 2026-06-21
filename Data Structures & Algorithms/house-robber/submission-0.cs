public class Solution {
    public int Rob(int[] nums) {
        int[] memo = new int[nums.Length];
        Array.Fill(memo,-1);
        return DP(0,nums , memo);
    }
    int DP(int i , int[] nums , int[] memo)
    {
        if(i>= nums.Length)return 0;

        if(memo[i] != -1)return memo[i];

        memo[i] = Math.Max( nums[i] + DP(i+2 , nums , memo) , DP(i+1 , nums , memo) );

        return memo[i];
    }
}
