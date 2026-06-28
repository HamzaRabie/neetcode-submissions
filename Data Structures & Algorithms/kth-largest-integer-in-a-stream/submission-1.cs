public class KthLargest {
    PriorityQueue<int,int> pq;
    int k =0;
    public KthLargest(int k, int[] nums) {
        pq = new PriorityQueue<int, int>();
        this.k = k;

        for(int i=0 ; i<nums.Length ; i++)
        {
            pq.Enqueue(nums[i] , nums[i]);
            if(pq.Count > k)pq.Dequeue();
        }
    }
    
    public int Add(int val) {
        pq.Enqueue(val,val);
        if(pq.Count > k)
            pq.Dequeue();
        return pq.Peek();   
    }
}