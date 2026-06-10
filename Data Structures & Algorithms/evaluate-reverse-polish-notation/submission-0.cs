public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> s = new Stack<int>();
        int res=0;
        string opt = "+-*/";
        for(int i=0 ; i<tokens.Length ; i++)
        {
            if (tokens[i] == "+")
            {
                s.Push( s.Pop() + s.Pop() );
            }
            else  if (tokens[i] == "-")
            {
                int n1 = s.Pop();
                s.Push( s.Pop() - n1 );
            }
            else  if (tokens[i] == "*")
            {
                s.Push( s.Pop() * s.Pop() );
            }
            else  if (tokens[i] == "/")
            {
                int n1 = s.Pop();
                s.Push( s.Pop() / n1);
            }
            else s.Push(int.Parse(tokens[i]));

        }
        while(s.Count > 0)
        {
            res += s.Pop();
        }
        return res;
    }
}