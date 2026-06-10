public class MinStack {
    Stack<int> s , mn;

    public MinStack() {
        s = new Stack<int>();
        mn = new Stack<int>();
    }
    
    public void Push(int val) {
        s.Push(val);
        if(mn.Count == 0 || val <= mn.Peek())
            mn.Push(val);
        else mn.Push(mn.Peek());
    }
    
    public void Pop() {
        s.Pop();
        mn.Pop();
    }
    
    public int Top() {
        return s.Peek();
    }
    
    public int GetMin() {
        return mn.Peek();
    }
}
