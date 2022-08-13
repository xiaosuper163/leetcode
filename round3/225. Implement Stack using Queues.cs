public class MyStack {
    
    private Queue<int> q1;
    private Queue<int> q2;

    public MyStack() {
        q1 = new Queue<int>();
        q2 = new Queue<int>();
    }
    
    public void Push(int x) {
        q1.Enqueue(x);
        if (q1.Count > 1) {
            int curr = q1.Dequeue();
            q2.Enqueue(curr);
        }
    }
    
    public int Pop() {
        int res = q1.Dequeue();
        int cnt = q2.Count;
        for (int i = 0; i < cnt-1; i ++) {
            int curr = q2.Dequeue();
            q2.Enqueue(curr);
        }
        if (cnt > 0) q1.Enqueue(q2.Dequeue());
        return res;
    }
    
    public int Top() {
        return q1.Peek();
    }
    
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