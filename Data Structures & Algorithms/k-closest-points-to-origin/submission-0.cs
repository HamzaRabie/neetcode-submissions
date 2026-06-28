public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<(int,int),int> pq = new ();

        for(int i=0 ; i<points.Length ; i++)
        {
            pq.Enqueue((points[i][0],points[i][1]), ((points[i][0] * points[i][0]) + (points[i][1] * points[i][1])) );
        }

        int[][] res = new int[k][];

for (int i = 0; i < k; i++)
{
    res[i] = new int[2];
}

        int j=0;
        while(j < k)
        {
            var p = pq.Dequeue();
            res[j][0] = p.Item1;
            res[j][1] = p.Item2;
            j++;
        }
        return res;
    }
}