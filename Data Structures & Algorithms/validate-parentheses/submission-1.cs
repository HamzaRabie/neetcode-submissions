public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();
        string open ="({[";
        for(int  i=0 ; i<s.Length ; i++)
        {
            if( open.Contains(s[i]) ) st.Push(s[i]);
            else if(st.Count == 0) return false;
            else if(s[i]==']' && st.Peek() !='[')return false;
            else if(s[i]=='}' && st.Peek() !='{')return false;
            else if(s[i]==')' && st.Peek() !='(')return false;
            else st.Pop();
        }
        return st.Count == 0;
    }
}