public class Solution {
    List<List<string>> res = new List<List<string>>();
    public List<List<string>> SolveNQueens(int n) {
        List<string> curr = new List<string>();
        DFS(0,n,curr);
        return res;
    }
    void DFS(int i , int n , List<string> curr)
    {
        
        if(n == i ){res.Add(new List<string>(curr));return;}

        for(int j=0 ; j<n ; j++)
        {
            if(isValid(j , curr))
            {
                char[] row = new string('.', n).ToCharArray();
                row[j] = 'Q';
                string result = new string(row);

                curr.Add(result);
                DFS(i + 1, n, curr);
                curr.RemoveAt(curr.Count -1 );
            }
        }
    }
    bool isValid(int cl , List<string> curr)
    {   
        for(int i=0 ; i<curr.Count ; i++)
        {
           if( curr[i][cl] == 'Q' )return false;
        }
        for(int i=curr.Count -1 , j=cl-1 ; i>=0 && j>=0 ; i--,j--)
        {
            if(curr[i][j] == 'Q')return false;
        }
        for(int i=curr.Count -1 , j=cl+1 ; i>=0 && j<curr[i].Length ; i--,j++)
        {
            if(curr[i][j] == 'Q')return false;
        }
        return true;
    }
}