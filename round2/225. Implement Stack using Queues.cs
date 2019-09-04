public class MyStack {
    public Queue<int> q1 {get; set;}
    public Queue<int> q2 {get; set;}

    /** Initialize your data structure here. */
    public MyStack() {
        q1 = new Queue<int>();
        q2 = new Queue<int>();
    }
    
    /** Push element x onto stack. */
    public void Push(int x) {
        q1.Enqueue(x);
        if (q1.Count > 1) {
            q2.Enqueue(q1.Dequeue());
        }
    }
    
    /** Removes the element on top of the stack and returns that element. */
    public int Pop() {
        int toPop = Top();
        q1.Dequeue();
        return toPop;
    }
    
    /** Get the top element. */
    public int Top() {
        if (q1.Count > 0) return q1.Peek();
        int size = q2.Count;
        for (int i=0; i<size-1; i++) {
            int tmp = q2.Dequeue();
            q2.Enqueue(tmp);
        }
        q1.Enqueue(q2.Dequeue());
        return q1.Peek();
    }
    
    /** Returns whether the stack is empty. */
    public bool Empty() {
        return q1.Count == 0 && q2.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */