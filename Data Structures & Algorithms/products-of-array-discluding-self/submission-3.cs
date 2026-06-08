public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int pr = nums[0];
        int[] res = new int[nums.Length];
        res[0] = 1;
        for(int i=1 ; i<nums.Length ; i++)
        {
            res[i] = pr;
            pr *= nums[i];
        }
        pr=nums[nums.Length-1];
        for(int i=nums.Length-2 ; i>=0 ; i--)
        {
            res[i] *= pr;
            pr *= nums[i];
        }

        return res;
    }
}