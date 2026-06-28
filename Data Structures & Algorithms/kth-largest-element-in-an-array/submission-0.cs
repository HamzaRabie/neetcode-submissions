public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int,int> pq = new ();

        for(int i=0 ; i<nums.Length ; i++)
        {
            pq.Enqueue( nums[i] , -nums[i] );
        }
        int res=0;
        while(k-- > 0)
        {
            res = pq.Dequeue();
        }
        return res;
    }
}