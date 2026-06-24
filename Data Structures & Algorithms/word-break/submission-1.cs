public class Solution {
    public bool WordBreak(string s, List<string> wordDict)
    {
        HashSet<string> words = new(wordDict);
        int[] memo = new int[s.Length];
        return DP(0,s,words,memo);
    }
    bool DP(int i , string s, HashSet<string> wordDict, int[] memo)
    {
        if(i == s.Length) return true;

        if(memo[i] != 0) return memo[i] == 1;

        for(int j = i+1; j <= s.Length; j++)
        {
            if(wordDict.Contains(s.Substring(i,j-i)) && DP(j,s,wordDict,memo))
            {
                memo[i] = 1;
                return true;
            }
        }

        memo[i] = -1;
        return false;
    }
}