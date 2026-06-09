public class Solution {
    public int Trap(int[] height) {
        int res=0 , left=0 , right = height.Length-1 , leftMax=0 , rightMax=0;
        while(left < right)
        {
            if(height[left] <= height[right])
            {
                leftMax = Math.Max(leftMax , height[left]);
                res += leftMax - height[left];
                left++;
            }
            else
            {
                rightMax = Math.Max(rightMax , height[right]);
                res += rightMax - height[right];
                right--;
            }
        }
        return res;
    }
}