public class Solution {

    List<List<string>> res = new List<List<string>>();
    public List<List<string>> Partition(string s) {
        List<string> curr = new List<string>();
        DFS(0,s,curr);
        return res;
    }
    void DFS(int i, string s , List<string> curr)
    {
        if(i == s.Length)
        {
            res.Add(new List<string>(curr));
            return ;
        }

        for(int j = i; j < s.Length; j++)
        {
            if(isPalind(s.Substring(i,j-i+1)))
            {
                curr.Add(s.Substring(i,j-i+1));
                DFS(j+1,s,curr);
                curr.RemoveAt(curr.Count-1);
            }
        }
        
    }

    bool isPalind(string s)
    {
        return s.SequenceEqual(s.Reverse());
    }
}

