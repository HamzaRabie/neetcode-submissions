public class Solution {
    public bool CanPartition(int[] nums) {
        int total = nums.Sum();
        if(total % 2 !=0)return false;

        int[][] memo = new int[nums.Length][];
        for(int i=0;i<nums.Length;i++)
        {
            memo[i] = new int[(total/2)+1];
            Array.Fill(memo[i],-1);
        }

        return DP(0,nums,total/2,memo);
    }
    bool DP(int i , int[]nums , int target , int[][] memo)
    {
        if(target == 0)return true;

        if(i==nums.Length || target < 0)return false;

        if(memo[i][target] != -1)return memo[i][target] == 1;

        memo[i][target] = (DP(i+1 , nums , target-nums[i] , memo) || DP(i+1 , nums , target , memo)) == true ? 1 : 0;

        return memo[i][target] == 1;
    }
}