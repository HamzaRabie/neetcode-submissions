public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int,int> pq = new ();
        for(int i=0 ; i<stones.Length; i++)
        {
            pq.Enqueue(stones[i] , -stones[i]);
        }

        while(pq.Count > 1)
        {
            int s1 = pq.Dequeue();
            int s2 = pq.Dequeue();

            if(s1 - s2 > 0 )pq.Enqueue(s1-s2 , (s1-s2)*-1);
        }

        return pq.Count == 0 ? 0 : pq.Peek();
    }
}