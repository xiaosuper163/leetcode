/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;

    public Node(){}
    public Node(int _val,Node _next,Node _random) {
        val = _val;
        next = _next;
        random = _random;
}
*/
public class Solution {
    public Node CopyRandomList(Node head) {
        if (head == null) return null;
        Node cursor = head;
        var mappings = new Dictionary<int, Node>();
        while (cursor != null) {
            mappings[cursor.val] = new Node(cursor.val, null, null);
            cursor = cursor.next;
        }
        cursor = head;
        while (cursor != null) {
            if (cursor.next != null)
                mappings[cursor.val].next = mappings[cursor.next.val];
            if (cursor.random != null)
               mappings[cursor.val].random = mappings[cursor.random.val];
            cursor = cursor.next;
        }
        return mappings[head.val];
    }
}