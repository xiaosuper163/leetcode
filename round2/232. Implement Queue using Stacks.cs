public class MyQueue {
    private Stack<int> st1;
    private Stack<int> st2;

    /** Initialize your data structure here. */
    public MyQueue() {
        st1 = new Stack<int>();
        st2 = new Stack<int>();
    }
    
    /** Push element x to the back of queue. */
    public void Push(int x) {
        st1.Push(x);
    }
    
    /** Removes the element from in front of queue and returns that element. */
    public int Pop() {
        int tmp = Peek();
        st2.Pop();
        return tmp;
    }
    
    /** Get the front element. */
    public int Peek() {
        if (st2.Count == 0) {
            while (st1.Count != 0) {
                st2.Push(st1.Pop());
            }
        }
        return st2.Peek();
    }
    
    /** Returns whether the queue is empty. */
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