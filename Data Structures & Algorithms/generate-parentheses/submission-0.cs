public class Solution {
    List<string> res = new List<string>();
    public List<string> GenerateParenthesis(int n) {
        string s = "";
        DFS(n , n , s);
        return res;
    }
    void DFS(int op , int cl , string s)
    {
        if(op == 0 && cl == 0){res.Add(s);return;}
        if(op < 0 || cl < 0)return ;

        DFS(op-1 , cl , s+"(");

        if(op < cl)
            DFS(op , cl-1 , s+")");

    }
}