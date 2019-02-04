// Two Pointers
// Keep track of two linked lists

/**
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} head
 * @param {number} x
 * @return {ListNode}
 */
var partition = function(head, x) {
    var dummy1 = new ListNode(0);
    var left = dummy1;
    var cursor = head;
    
    var dummy2 = new ListNode(0);
    var right = dummy2;
    
    while(cursor !== null) {
        var temp = cursor.next;
        if (cursor.val < x) {
            left.next = cursor;
            left = left.next;
        } else {
            right.next = cursor;
            right = right.next;
            right.next = null;
        }
        cursor = temp;
    }
    left.next = dummy2.next;
    return dummy1.next;
};