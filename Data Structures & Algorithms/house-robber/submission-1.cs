
public class Solution {
    public int Rob(int[] nums) {
        int n = nums.Length;
        int[] memo = new int[n+1 ];
        Array.Fill(memo,-1);

        memo[n] = 0 ;
        memo[n-1] = nums[n-1];

        for(int i=n-2 ; i>=0 ; i--)
        {
            memo[i] = Math.Max( nums[i] + memo[i+2] , memo[i+1] );
        }
        return memo[0];

    }
   
}