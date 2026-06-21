public class Solution {
    public int Rob(int[] nums) {
        int[] memo1 = new int[nums.Length];
        int[] memo2 = new int[nums.Length];

        if(nums.Length==1)return nums[0];

        Array.Fill(memo1,-1);
        Array.Fill(memo2,-1);

        return Math.Max(
            DP(0, nums.Length-2, nums, memo1),
                    DP(1, nums.Length-1, nums, memo2));
    }
    int DP(int i , int en , int[] nums , int[] memo)
    {
        if(i > en)return 0;

        if(memo[i] != -1)return memo[i];

        memo[i] = Math.Max( nums[i] + DP(i+2 ,en, nums , memo) , DP(i+1 ,en, nums , memo) );

        return memo[i];
    }
}