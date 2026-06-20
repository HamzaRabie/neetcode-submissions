public class Solution {
    public bool Exist(char[][] board, string word ) {

    for(int i = 0 ; i < board.Length ; i++)
    {
            for(int j = 0 ; j < board[0].Length ; j++)
            {
                if(board[i][j] == word[0])
                {
                    if(DFS(i,j,board , word , "")) return true;
                }
            }
        }
        return false;
    }

    bool DFS(int i , int j ,char[][] board, string word , string res)
    {
        if(res == word)return true;

        if(i < 0 || j < 0 || i>= board.Length || j >= board[0].Length || !(word.StartsWith(res)) || board[i][j] =='#') return false;

        char temp = board[i][j];
        board[i][j] = '#';
        bool ans = DFS(i+1 , j , board , word  , res+temp) 
        ||
        DFS(i-1 , j , board , word  , res+temp)
        ||
        DFS(i , j+1 , board , word  , res+temp) 
        ||
        DFS(i , j-1 , board , word  , res+temp);

        board[i][j] = temp;
        return ans;
        

    }
}