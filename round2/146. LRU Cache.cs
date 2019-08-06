public class Node {
    public int key {get; set;}
    public int val {get; set;}
    public Node next {get; set;}
    public Node prev {get; set;}
    public Node(int k, int v) {
        key = k;
        val = v;
        next = null;
        prev = null;
    }
}

public class LRUCache {
    private int _capacity;
    private int Count;
    private Dictionary<int, Node> m;
    private Node head;
    private Node tail;

    public LRUCache(int capacity) {
        _capacity = capacity;
        Count = 0;
        m = new Dictionary<int, Node>();
        head = null;
        tail = null;
    }
    
    public int Get(int key) {
        if (!m.ContainsKey(key)) {
            return -1;
        }
        if (tail == m[key]) return tail.val;
        Node target = m[key];
        if (target.prev != null) {
            target.prev.next = target.next;
            target.next.prev = target.prev;
        } else {
            head = target.next;
            target.next.prev = null;
        }
        target.next = null;
        target.prev = tail;
        tail.next = target;
        tail = target;
        return tail.val;
    }
    
    public void Put(int key, int value) {
        if (m.ContainsKey(key)) {
            m[key].val = value;
            Get(key);
        } else {
            var node = new Node(key, value);
            m[key] = node;
            if (Count == 0) {               
                head = node;
                tail = node;
                Count++;
                return;
            } else {
                tail.next = node;
                node.prev = tail;
                tail = node;
                if (Count < _capacity) {
                    Count++;
                    return;
                } else {
                    m.Remove(head.key);
                    head = head.next;
                    head.prev = null;
                }
            }
        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */