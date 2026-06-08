public class Solution {
    public bool IsValidSudoku(char[][] board) {
        for(int i=0 ; i<9 ; i++)
        {
            HashSet<char> row = new HashSet<char>();
            for(int j=0 ; j<9 ; j++)
            {
                if(board[i][j]=='.')continue;
                if(row.Contains(board[i][j])) return false;
                row.Add(board[i][j]);
            }
        }

        for(int i=0 ; i<9 ; i++)
        {
            HashSet<char> cols = new HashSet<char>();
            for(int j=0 ; j<9 ; j++)
            {
                if(board[j][i]=='.')continue;
                if(cols.Contains(board[j][i])) return false;
                cols.Add(board[j][i]);
            }
        }


        for(int r=1;  r<=3 ; r++)
        {
            for(int c=1 ; c<=3 ; c++)
            {
                HashSet<char> group = new HashSet<char>();
                for(int i= 3*(r-1) ; i<= (3*r)-1 ; i++)
                {
                    for(int j= 3*(c-1) ; j<= (3*c)-1 ; j++)
                    {
                        if(board[i][j]=='.')continue;

                        if(group.Contains(board[i][j]))return false;
                        group.Add(board[i][j]);

                    }
                }
            }
            
        }


        return true;
    }
}