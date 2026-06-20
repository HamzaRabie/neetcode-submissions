public class Solution {
    string [] mapping = new string[] {"0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};
    List<string> res = new List<string>();       
    public List<string> LetterCombinations(string digits)
    {
        string curr = "";
        DFS(0,digits,curr);
        return res;
    }
    void DFS(int i , string digits , string curr)
    {
        if( i == digits.Length)
        {
            if(curr.Length > 0)
                res.Add(curr);
            return;
        }

        int mp = digits[i] - '0';
        for(int k=0 ; k<mapping[mp].Length ; k++)
        {
            curr+=mapping[mp][k];
            DFS(i+1 , digits , curr);
            curr = curr.Substring(0,curr.Length-1);
        }
        
    }
}