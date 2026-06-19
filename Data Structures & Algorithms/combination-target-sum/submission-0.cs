public class Solution {
    List<List<int>> res = new List<List<int>> ();
    public List<List<int>> CombinationSum(int[] candidates, int target) {
        List<int> curr = new List<int>();
        DFS(0,candidates , curr , target);
        return res;
    }
    
    void DFS(int i , int[] candidates, List<int> curr, int target )
    {

        //base case
        if(target == 0){res.Add(new List<int> (curr)); return ;}
        if(target < 0 || i == candidates.Length) return ;

        curr.Add(candidates[i]);
        DFS(i , candidates , curr , target - candidates[i]);
        curr.RemoveAt(curr.Count -1);

        DFS(i+1 , candidates , curr , target);

    }
}