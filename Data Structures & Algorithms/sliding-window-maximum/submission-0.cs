public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        Dictionary<int, int> d = new Dictionary<int, int>();
        PriorityQueue<int,int> pq = new();
        List<int> res = new List<int>();
        for(int i=0 ; i<k ; i++)
        {
            if(!d.ContainsKey(nums[i]))d.Add(nums[i],0);
            d[nums[i]]++;
            pq.Enqueue(nums[i],-nums[i]);
        }
        res.Add(pq.Peek());

        for(int i=k ; i<nums.Length ; i++)
        {
            
            int deleted = nums[i - k];
            d[deleted]--;

            if(!d.ContainsKey(nums[i]))d.Add(nums[i],0);
            d[nums[i]]++;

            pq.Enqueue(nums[i],-nums[i]);

            while( d[pq.Peek()] <= 0)
            {
                pq.Dequeue();
            }
            res.Add(pq.Peek());

        }
        return res.ToArray();
    }
}