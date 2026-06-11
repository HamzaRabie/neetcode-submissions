public class Solution {
    public int LargestRectangleArea(int[] heights) {
        Stack<(int h , int idx)> s = new();
        int res=0;
        for(int i=0 ; i<heights.Length ; i++)
        {
            if(s.Count == 0 || s.Peek().h <= heights[i])s.Push((heights[i] , i));
            else
            {
                int st = i;
                while(s.Count > 0 && s.Peek().h > heights[i])
                {
                    var top = s.Pop();
                    st = top.idx;
                    res = Math.Max(res , (i - top.idx)* top.h);
                }
                s.Push( (heights[i] , st) );
            }
        }

        int j= heights.Length;
        while(s.Count > 0)
        {
            res = Math.Max(res , (j - s.Peek().idx)* s.Peek().h);
            s.Pop();
        }
        return res;
    }
}