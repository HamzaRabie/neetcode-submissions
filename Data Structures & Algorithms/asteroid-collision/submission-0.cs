public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> s = new Stack<int>();
        for(int i=0 ; i<asteroids.Length ; i++)
        {
            if(asteroids[i] > 0)s.Push(asteroids[i]);
            else 
            {
                while(s.Count > 0 && s.Peek()>0 && s.Peek() < Math.Abs(asteroids[i]))
                {
                    s.Pop();
                }

                if(s.Count > 0 && s.Peek() == Math.Abs(asteroids[i]) )s.Pop();

                else if (s.Count > 0 && s.Peek() > Math.Abs(asteroids[i]))continue;
                else s.Push(asteroids[i]);
                
            }
            Console.WriteLine(s.Count);
        }
        int[] res = new int[s.Count];
        int j=s.Count-1;
        while(s.Count > 0)
        {
            res[j--] = s.Pop();
        }
        return res;
    }
}