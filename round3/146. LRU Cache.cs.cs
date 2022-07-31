public class Node {
    public Node next;
    public Node prev;
    public int val;
    public int key;
    public Node(int k, int v) {
        key = k;
        val = v;
        prev = null;
        next = null;
    }
}

public class LRUCache {
    
    private Dictionary<int, Node> dict;
    private int count;
    private Node head;
    private Node tail;
    private int _capacity;

    public LRUCache(int capacity) {
        _capacity = capacity;
        count = 0;
        dict = new Dictionary<int, Node>();
        head = null;
        tail = null;
    }
    
    public int Get(int key) {
        if (!dict.ContainsKey(key)) return -1;
        Node target = dict[key];
        if (target != tail) {
            if (target == head) {
                Node tmp = target.next;
                tmp.prev = null;
                target.next = null;
                head = tmp;
                tail.next = target;
                target.prev = tail;
                tail = target;
            } else {
                target.next.prev = target.prev;
                target.prev.next = target.next;
                tail.next = target;
                target.prev = tail;
                tail = target;
                target.next = null;
            }
        }   
            
        return target.val;
    }
    
    public void Put(int key, int value) {
        if (dict.ContainsKey(key)) {
            Get(key);
            dict[key].val = value;
        } else {
            dict[key] = new Node(key, value);
            count ++;
            if (count == 1) {
                head = dict[key];
                tail = dict[key];
            } else {                
                tail.next = dict[key];
                dict[key].prev = tail;
                tail = dict[key];
                
                if (count > _capacity) {
                    dict.Remove(head.key);
                    head.next.prev = null;
                    head = head.next;                    
                    count --;
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