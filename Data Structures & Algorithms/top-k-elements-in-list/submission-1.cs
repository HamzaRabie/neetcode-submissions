public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> d = new Dictionary<int, int>();
        PriorityQueue<int,int> pq = new PriorityQueue<int, int>();
        for(int i=0 ; i<nums.Length ; i++)
        {
            if(!d.ContainsKey(nums[i]))d.Add(nums[i],0);
            d[nums[i]]++;
        }
        foreach(var kvp in d)
        {
            pq.Enqueue(kvp.Key,kvp.Value);
            if(pq.Count > k) pq.Dequeue();
        }
        int j=0;
        int []res=new int[k];
        while (j<k)
        {
            res[j++] = pq.Dequeue();
        }
        return res;

    }
}