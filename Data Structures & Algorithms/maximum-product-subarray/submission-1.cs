public class Solution {
    public int MaxProduct(int[] nums) {
        int n = nums.Length;

        int maxProduct = nums[0];
        int[] mx = new int[n];
        int[] mn = new int[n];

        mx[0] = nums[0];
        mn[0] = nums[0];

        for(int i=1 ; i<nums.Length  ; i++)
        {

            mx[i] = Math.Max(nums[i] , 
                Math.Max(
                    nums[i] * mn[i-1] ,
                    nums[i] * mx[i-1]
                )
            );

            mn[i] = Math.Min(nums[i] , 
                Math.Min(
                    nums[i] * mn[i-1] ,
                    nums[i] * mx[i-1]
                )
            );

            maxProduct = Math.Max(maxProduct , mx[i]);

        }
        return maxProduct;
    }
}