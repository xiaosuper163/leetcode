/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        if (head == null) return head;
        
        var dummy = new Node(0);
        var newDummy = new Node(0);
        
        dummy.next = head;
        
        var curr = head;
        Node post;
        Node cursor = newDummy;
        
        while (curr != null) {
            post = curr.next;
            curr.next = new Node(curr.val);
            curr.next.next = post;
            curr = post;
        }
        
        curr = dummy.next;
        while (curr != null) {
            if (curr.random != null) curr.next.random = curr.random.next;
            curr = curr.next.next;
        }
        
        curr = dummy.next;
        while (curr != null) {
            cursor.next = curr.next;
            cursor = cursor.next;
            curr.next = curr.next.next;
            curr = curr.next;
        }
        
        return newDummy.next;
    }
}