public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int res=0 , n = grid.Length  , m= grid[0].Length;
        for(int i=0 ; i<n ; i++)
        {
            for(int j=0 ; j<m ; j++)
            {
                if(grid[i][j] == 1)
                {
                    res = Math.Max(res , DFS(i,j,n,m,grid));
                }
            }
        }
        return res;
    }
    int DFS(int i , int j , int n , int m ,int[][] grid)
    {
        if(i<0 || i>=n || j<0 || j>=m || grid[i][j] == 0)return 0;

        grid[i][j] =0;

        return 1 + DFS(i+1, j , n , m , grid)+ 
                DFS(i-1, j , n , m , grid)+ 
                DFS(i, j+1 , n , m , grid)+ 
                DFS(i, j-1 , n , m , grid);
    }
}