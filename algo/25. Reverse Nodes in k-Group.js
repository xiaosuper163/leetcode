// @9 Linked List

/**
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} head
 * @param {number} k
 * @return {ListNode}
 */
var reverseKGroup = function(head, k) {
    // define a function to reverse a single group of size k
    // return the node right before the next group
    var reverseSingleGroup = function(h) {
        var n1 = h.next;
        var nkNext = h.next;
        // group size less than k
        for (var i = 0; i < k; i++) {
            if (nkNext === null) {
                return;
            }
            nkNext = nkNext.next;
        }
        
        var prev = h.next;
        var curr = prev.next;
        // reverse
        for (var i=0; i<k-1; i++) {
            var temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        // connect
        h.next = prev;
        n1.next = nkNext;
        return n1;
    };
    
    var dummy = new ListNode(0);
    dummy.next = head;
    head = dummy;
    while(head != null) {
        head = reverseSingleGroup(head);
    }    
    return dummy.next;
};