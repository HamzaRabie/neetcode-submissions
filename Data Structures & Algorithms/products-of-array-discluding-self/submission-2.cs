public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int pr = nums[0];
        int[] tmp1 = new int[nums.Length];
        int[] tmp2 = new int[nums.Length];
        tmp1[0] = 1;
        for(int i=1 ; i<nums.Length ; i++)
        {
            tmp1[i] = pr;
            pr *= nums[i];
        }
        pr=nums[nums.Length-1];
        tmp2[nums.Length-1] = 1;
        for(int i=nums.Length-2 ; i>=0 ; i--)
        {
            tmp2[i] = pr;
            pr *= nums[i];
        }
        int[] res = new int[nums.Length];
        for(int i=0 ; i<nums.Length ; i++)
        {
            res[i] = tmp1[i] * tmp2[i];
        }
        return res;
    }
}