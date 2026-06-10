public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int> s = new Stack<int>();
        int[] res =new int[temperatures.Length];
        for(int i = temperatures.Length-1 ; i>=0 ; i--)
        {
            while( s.Count > 0 && temperatures[s.Peek()] <= temperatures[i])
            {
                s.Pop();
            }

            if(s.Count > 0)res[i] = s.Peek() - i;
            else res[i] = 0;

            s.Push(i);
        }
        return res;
    }
}