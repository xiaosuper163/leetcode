public class MinStack {
    
    private Stack<int> st1;
    private Stack<int> st2;
    /** initialize your data structure here. */
    public MinStack() {
        st1 = new Stack<int>();
        st2 = new Stack<int>();
    }
    
    public void Push(int x) {
        st1.Push(x);
        if(st2.Count == 0 || x <= st2.Peek()) st2.Push(x);
    }
    
    public void Pop() {
        if (st1.Peek() == st2.Peek()) st2.Pop();
        st1.Pop();        
    }
    
    public int Top() {
        return st1.Peek();
    }
    
    public int GetMin() {
        return st2.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */