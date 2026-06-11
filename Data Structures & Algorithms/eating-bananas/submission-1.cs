public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l=1 , r=1000000000;
        while (l < r)
        {
            int mid = l + (r-l)/2;
            if(check(mid,h,piles))r=mid;
            else l=mid+1;
        }
        return r;
    }
    bool check(int k , int h , int[] piles)
    {
        int time=0;
        for(int i=0 ; i<piles.Length ; i++)
        {
            if(piles[i] < k)time++;
            else time +=  ((int)Math.Ceiling((decimal)piles[i]/k));
        }
        return time <= h;
    }
}