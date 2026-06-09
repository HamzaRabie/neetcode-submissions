public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        nums = nums.Order().ToArray();
        List<List<int>> res  = new List<List<int>>();
        
        for(int i=0 ; i<nums.Length ; i++)
        {
            int r = nums.Length-1 ;
            for(int j=i+1 ; j<nums.Length ; j++)
            {
                while (r > j)
                {
                    if( nums[i] + nums[j] + nums[r] < 0 )j++;
                    else if( nums[i] + nums[j] + nums[r] > 0  )r--;
                    else
                    {
                        res.Add(new List<int>{nums[i],nums[j],nums[r]});
                        while(j+1<nums.Length && nums[j] == nums[j+1]){j++;}
                        while(r-1>=0 && nums[r] == nums[r-1]){r--;}//could skip
                        break;
                    }
                }
                
            }
            while(i+1<nums.Length && nums[i] == nums[i+1]){i++;}
        }
        return res;
    }
}
