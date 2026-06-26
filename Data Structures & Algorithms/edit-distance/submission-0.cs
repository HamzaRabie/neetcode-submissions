public class Solution {
    public int MinDistance(string word1, string word2) {
        int[,] memo = new int[word1.Length, word2.Length];
        for(int i = 0; i < word1.Length; i++)
            for(int j = 0; j < word2.Length; j++)
                memo[i,j] = -1;
        return DP(0,0,word1,word2,memo);
    }
    int DP(int i, int j, string word1, string word2, int[,] memo)
    {
        if(i == word1.Length)return word2.Length - j;
        if(j == word2.Length)return word1.Length - i;

        if(memo[i,j] != -1)return memo[i,j];

        if(word1[i] == word2[j])
            return DP(i+1,j+1,word1,word2,memo);

        int insert = 1 + DP(i,j+1,word1,word2,memo);
        int delete = 1 + DP(i+1,j,word1,word2,memo);
        int replace = 1 + DP(i+1,j+1,word1,word2,memo);

        return memo[i,j] = Math.Min(insert,Math.Min(delete,replace));
    }
}