public class Solution {
    public int Trap(int[] height) {
        int res=0;
        int n = height.Length;
        int[] L = new int[n];
        int[] R = new int[n];
        int mx=0;
        for(int i=0 ; i<n ; i++)
        {
            L[i] = mx;
            mx = Math.Max(mx, height[i]); 
        }
        mx=0;
        for(int i=n-1 ; i>=0 ; i--)
        {
            R[i] = mx;
            mx = Math.Max(mx, height[i]); 
        }
        for(int i=1 ; i<n-1 ; i++)
        {
            int water = Math.Min(L[i],R[i]) - height[i];
            if(water > 0) res += water;
        }

        return res;
    }
}