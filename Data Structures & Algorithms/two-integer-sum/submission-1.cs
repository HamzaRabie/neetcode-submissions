public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> d = new Dictionary<int, int>();
        int[] res = new int[2];
        for(int i=0 ; i<nums.Length ; i++)
        {
            if(!d.ContainsKey(nums[i]))d.Add(nums[i],i);
            else d[nums[i]] = i;
        }

        for(int i=0 ; i<nums.Length ; i++)
        {
            if(d.ContainsKey(target-nums[i]) && d[target-nums[i]] != i) {res[0]=i;res[1]=d[target-nums[i]]; break;}
        }
        return res;
    }
}