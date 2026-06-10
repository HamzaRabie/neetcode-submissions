public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        List<(int p , int s)> l = new List<(int p, int s)>();
        for(int i=0 ; i<position.Length ; i++)
        {
            l.Add((position[i] , speed[i]));
        }
        l = l.OrderByDescending(x => x.p).ToList();

        List<double> time = new List<double>();
        for(int i=0 ; i<l.Count ; i++)
        {
            time.Add( (double)(target - l[i].p) / l[i].s );
        }

        Stack<double> s = new Stack<double>();
        for(int i=0 ; i<time.Count ; i++)
        {
            if(s.Count == 0)s.Push(time[i]);
            else
            {
                if( s.Peek() < time[i] )s.Push(time[i]);
            }
        }
        return s.Count;
    }
}