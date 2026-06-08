public class Solution {
    public int LongestConsecutive(int[] nums) {
        Dictionary<int,int> d = new Dictionary<int, int>();
        for(int i=0 ; i<nums.Length ; i++)
        {
            if(!d.ContainsKey(nums[i]))d.Add(nums[i],0);
            d[nums[i]]++;
        }
        int res=0;
        foreach(var item in d)
        {
            if (!d.ContainsKey(item.Key + 1))
            {
                var num = item.Key;
                int tmp=0;
                while (d.ContainsKey(num--))
                {
                    tmp++;
                }
                res = Math.Max(res,tmp);
            }
        }
        return res;
    }
}