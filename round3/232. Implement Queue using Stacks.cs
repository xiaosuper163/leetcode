public class MyQueue {
    
    private Stack<int> st1;
    private Stack<int> st2;

    public MyQueue() {
        st1 = new Stack<int>();
        st2 = new Stack<int>();
    }
    
    public void Push(int x) {
        if (st1.Count == 0) {
            st1.Push(x);
        } else {
            st2.Push(x);
        }
    }
    
    public int Pop() {
        int head = st1.Pop();
        if (st2.Count == 0) return head;
        
        int cnt = st2.Count - 1;
        for (int i = 0; i < cnt; i ++) {
            st1.Push(st2.Pop());
        }
        
        int newHead = st2.Pop();        
        for (int i = 0; i < cnt; i ++) {
            st2.Push(st1.Pop());
        }
        
        st1.Push(newHead);
        
        return head;
    }
    
    public int Peek() {
        return st1.Peek();
    }
    
    public bool Empty() {
        return st1.Count == 0 && st2.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */