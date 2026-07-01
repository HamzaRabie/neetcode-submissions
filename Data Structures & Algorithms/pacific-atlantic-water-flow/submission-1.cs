public class Solution {
    public List<List<int>> PacificAtlantic(int[][] heights) {
        List<List<int>> res = new List<List<int>>();
        int n = heights.Length , m = heights[0].Length ;

        bool[][] pacific = new bool[n][];
        bool[][] atlantic = new bool[n][];

        for(int i=0 ; i<n ; i++)
        {
            pacific[i] = new bool[m];
            atlantic[i] = new bool[m];
        }

        for(int i=0 ; i<m ; i++)
        {
            DFS(0,i,n,m,pacific,heights);
            DFS(n-1,i,n,m,atlantic,heights);
        }

        for(int i=0 ; i<n ; i++)
        {
            DFS(i,0,n,m,pacific,heights);
            DFS(i,m-1,n,m,atlantic,heights);
        }

        for(int i=0 ; i<n ; i++)
        {
            for(int j=0 ; j<m ; j++)
            {
                if(pacific[i][j] && atlantic[i][j]) res.Add(new List<int> { i, j });;
            }
        }
        return res;

    }
    void DFS(int i , int j , int n , int m ,bool[][] vis , int[][] heights )
    {
        if(vis[i][j] == true)return;

        vis[i][j] = true;

        if(i+1 < n && heights[i+1][j] >= heights[i][j]) DFS(i+1,j,n,m,vis,heights);

        if(i-1 >= 0 && heights[i-1][j] >= heights[i][j]) DFS(i-1,j,n,m,vis,heights);

        if(j+1 < m && heights[i][j+1] >= heights[i][j]) DFS(i,j+1,n,m,vis,heights);
        
        if(j-1 >= 0 && heights[i][j-1] >= heights[i][j]) DFS(i,j-1,n,m,vis,heights);

        
    }
}