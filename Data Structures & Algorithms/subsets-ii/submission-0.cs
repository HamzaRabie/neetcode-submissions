public class Solution {
    List<List<int>> res = new List<List<int>>();

    public List<List<int>> SubsetsWithDup(int[] nums) {
        List<int> curr = new List<int>();
        nums = nums.Order().ToArray();
        DFS(0 , nums , curr);
        return res;
    }
    void DFS(int i , int[] nums , List<int> curr)
    {
        if(i == nums.Length){res.Add(new List<int>(curr)); return;}

        curr.Add(nums[i]);

        DFS(i+1 , nums , curr);

        curr.RemoveAt(curr.Count - 1);

        int j=i;
        while(i < nums.Length && nums[i] == nums[j]){i++;}

        DFS(i , nums , curr);

    }
}