public class Solution {
    
    public int NumIslands(char[][] grid) {
        int n = grid.Length , m = grid[0].Length , res=0;

        for(int  i=0 ; i<n ; i++)
        {
            for(int j=0 ; j<m ; j++)
            {
                if( grid[i][j] != '0')
                {
                    res++;
                    DFS(i,j,n,m,grid);
                }
            }
        }
        return res;

    }
    void DFS(int i , int j , int n , int m ,char[][] grid)
    {
        if(i >=n || i < 0 || j >= m || j < 0 || grid[i][j] == '0')return ; 

        grid[i][j] = '0' ;

        DFS(i+1 , j , n , m , grid);
        DFS(i-1 , j , n , m , grid);
        DFS(i , j+1 , n , m , grid);
        DFS(i , j-1 , n , m , grid);

    }
}