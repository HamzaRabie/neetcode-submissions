public class Solution {
    List<List<int>> res = new List<List<int>>();
    public List<List<int>> Permute(int[] nums) {
        List<int> curr = new List<int>();
        DFS(0, nums, curr);
        return res;
    }
    void DFS(int i , int[] nums , List<int> curr)
    {
        if(curr.Count == nums.Length){res.Add(new List<int>(curr)); return;}

        for(int j=0 ; j < nums.Length ; j++)
        {
            if (curr.Contains(nums[j]))continue;

            curr.Add(nums[j]);
            DFS(j , nums , curr);
            curr.RemoveAt(curr.Count - 1);
        }
    }
}

