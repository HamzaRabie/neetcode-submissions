public class Solution {
    public bool WordBreak(string s, List<string> wordDict)
    {
        Dictionary<string,bool> memo = new Dictionary<string, bool>();
        return DP("",s,wordDict,memo);
    }
    bool DP(string curr , string s, List<string> wordDict , Dictionary<string,bool> memo)
    {
        if(!s.StartsWith(curr))return false;
        
        if(s == curr)return true;

        if(memo.ContainsKey(curr))return memo[curr];

        for(int i=0 ; i<wordDict.Count ; i++)
        {
            if( DP(curr+wordDict[i] , s , wordDict , memo) ){memo[curr] = true ;return true ;}
        }
        memo[curr] = false;
        return memo[curr];

    }
}