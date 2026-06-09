public class Solution {
    public int MaxArea(int[] heights) {
        int l=0 , r = heights.Length -1 , res=0;
        while(l < r)
        {
            res = Math.Max(res , ((r-l)*Math.Min(heights[l],heights[r])));
            if(heights[l] < heights[r])l++;
            else r--;
        }
        return res;
    }
}
