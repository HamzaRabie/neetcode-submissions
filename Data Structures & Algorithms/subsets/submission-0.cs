public class Solution {
    List<List<int>> res = new List<List<int>>();
    public List<List<int>> Subsets(int[] nums) {
        List<int> tmp = new List<int>();
        DFS(0 , nums , tmp);
        return res;
    }
    void DFS(int i , int[] nums , List<int> tmp)
    {
        if(i == nums.Length){res.Add(new List<int>(tmp)); ; return;}

        tmp.Add(nums[i]);

        DFS(i+1 , nums , tmp);

        tmp.RemoveAt(tmp.Count - 1);

        DFS(i+1 , nums , tmp);



    }
}
