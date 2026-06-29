public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        PriorityQueue<char,int> pq_run = new PriorityQueue<char, int>();
        PriorityQueue<(char c, int du),int> pq_cold = new PriorityQueue<(char c, int du), int>();
        Dictionary<char,int> d = new Dictionary<char, int>();

        //prepare data
        for(int i=0 ; i<tasks.Length ; i++)
        {
            if(!d.ContainsKey(tasks[i]))d.Add(tasks[i],0);
            d[tasks[i]]++;
        }
        foreach(var item in d)
        {
            pq_run.Enqueue(item.Key , -item.Value);
        }

        //(A => 3) , (B => 3)
        int time=1 , res=0;
        while(pq_cold.Count > 0 || pq_run.Count > 0)
        {
            while(pq_cold.Count > 0 && pq_cold.Peek().du <= time)
            {
                var cold = pq_cold.Dequeue();
                pq_run.Enqueue(cold.c , -d[cold.c]);
            }

            if(pq_run.Count > 0)
            {
                var running = pq_run.Dequeue();
                d[running]--; //finished one of it

                if(d[running] > 0)
                    pq_cold.Enqueue( (running ,time+n+1 ), time+n+1);
            }
            res++; 
            time++;
        }

        return res;
        
    }
}