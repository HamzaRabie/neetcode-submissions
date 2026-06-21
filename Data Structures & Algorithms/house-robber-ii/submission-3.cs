public class Solution {
    public int Rob(int[] nums) {
        int n = nums.Length;
        int[] memo1 = new int[n+1];
        int[] memo2 = new int[n+1];

        if(n == 1) return nums[0];

        return Math.Max(DP(0,n-1,nums,memo1), DP(1,n,nums,memo2));

    }
    int DP(int i , int j , int[] nums , int[] memo)
    {
        memo[j] = 0;
        memo[j-1] = Math.Max(nums[j-1], 0);

        for(int k = j-2; k >= i; k--)
        {
            memo[k] = Math.Max(nums[k] + memo[k+2], memo[k+1]);
        }
        return memo[i];
    }
   
}