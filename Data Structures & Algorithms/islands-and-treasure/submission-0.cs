public class Solution {
    public void islandsAndTreasure(int[][] grid) {
        int n = grid.Length , m = grid[0].Length ;
        for(int i=0 ;i<n; i++)
        {
            for(int j=0 ; j<m; j++)
            {
                if(grid[i][j] == 0)
                    DFS(i,j,n,m,0,grid);
            }
        }
    }
    void DFS(int i , int j , int n , int m , int steps , int[][] grid)
    {
        if( i<0 || i>=n || j<0 || j>=m ||  grid[i][j] == -1 )return ;

        if(steps > grid[i][j])return;

        if(grid[i][j] != 0)
            grid[i][j] = steps;

        DFS(i+1,j,n,m,grid[i][j]+1,grid);
        DFS(i-1,j,n,m,grid[i][j]+1,grid);
        DFS(i,j+1,n,m,grid[i][j]+1,grid);
        DFS(i,j-1,n,m,grid[i][j]+1,grid);
    }
}