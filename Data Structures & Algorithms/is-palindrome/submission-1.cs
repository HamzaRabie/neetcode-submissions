public class Solution {
    public bool IsPalindrome(string s) {
        s = s.Replace(" ","").ToLower();
       string alpha = "abcdefghijklmnopqrstuvwxyz0123456789";
        Console.WriteLine(s);
        int i=0 , j=s.Length-1;
        while (i <= j)
        {
            if(!alpha.Contains(s[i])){i++;continue;}
            if(!alpha.Contains(s[j])){j--;continue;}
            if(s[i++] != s[j--])return false;
        }
        return true;
    }
}