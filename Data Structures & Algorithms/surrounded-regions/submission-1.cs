public class Solution {
    public void Solve(char[][] board) {
        int n = board.Length , m = board[0].Length ;

        for(int i=0 ; i <n ; i++)
        {
            DFS(i,0,n,m,board);
            DFS(i,m-1,n,m,board);
        }

        for(int j=0 ; j < m ; j++)
        {
            DFS(0,j,n,m,board);
            DFS(n-1,j,n,m,board);
        }

        for(int i=0 ; i<n ; i++)
        {
            for(int j=0 ; j<m ; j++)
            {
                if(board[i][j] == '#')board[i][j] ='O';
                else if(board[i][j] == 'O') board[i][j]='X';
            }
        }

    }
    void DFS(int i , int j , int n , int m , char[][] board)
    {
        if(i<0 || i>=n || j<0 || j>=m || board[i][j] == 'X' || board[i][j] == '#' )return ;

        board[i][j] = '#'; 

        DFS(i+1,j,n,m,board);
        DFS(i-1,j,n,m,board);
        DFS(i,j+1,n,m,board);
        DFS(i,j-1,n,m,board);
    }
}