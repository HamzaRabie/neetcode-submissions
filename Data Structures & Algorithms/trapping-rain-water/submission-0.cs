public class Solution {
    public int Trap(int[] height) {
        int res=0;
        for(int i=0 ; i<height.Length ; i++)
        {
            int cnt=0; 
            int  idx= i+1 , j=i+1;
            for(; j<height.Length-1 ; j++)
            {
                if(height[j] >= height[idx]) idx = j;

                if( height[i] <= height[j] ){break;} //two boundries 

            }
            if(j-i == 1)continue; //no space for water
            if(j == height.Length - 1 && height[j] >= height[idx])idx=j;
            int calcVal = Math.Min(height[i] ,height[idx]);

            for(++i; i < idx ; i++)
            {
                res += (calcVal - height[i]);
            }
            --i;
        }
        return res;
    }
}