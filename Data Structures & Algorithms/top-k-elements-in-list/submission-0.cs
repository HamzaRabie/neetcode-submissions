public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> d = new Dictionary<int, int>();
        for(int i=0 ; i<nums.Length ; i++)
        {
            if(!d.ContainsKey(nums[i]))d.Add(nums[i],0);
            d[nums[i]]++;
        }
        d = d.OrderByDescending(e=>e.Value).ToDictionary();
        int[]res=new int[k];
        int j=0;
        foreach(var item in d)
        {   
            res[j++] = item.Key;
            if(--k == 0)break;
        }
        return res;

    }
}