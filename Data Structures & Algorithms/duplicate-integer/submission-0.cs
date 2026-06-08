public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> v = new HashSet<int>();
        for(int i=0 ; i<nums.Length ; i++)
        {
            if(v.Contains(nums[i]))return true;
            v.Add(nums[i]);
        }
        return false;
    }
}


