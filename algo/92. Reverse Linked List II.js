// Linked List

/**
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} head
 * @param {number} m
 * @param {number} n
 * @return {ListNode}
 */
var reverseBetween = function(head, m, n) {
    var dummy = new ListNode(0);
    dummy.next = head;
    var cursor = dummy;
    for (var i = 0; i < m-1; i ++) {
        if (cursor.next === null) {
            break;
        }
        cursor = cursor.next;
    }
    // cursor is used to store the node right before the mutation
    // cursor2 is used to store the node of first mutation
    // cursor2 will become the tail of reversed linked list
    var prev = cursor.next;
    var cursor2 = prev;
    var num_steps = n - m;
    
    curr = prev.next;
    while (curr !== null && num_steps != 0) {
        var temp = curr.next;
        curr.next = prev;
        prev = curr;
        curr = temp;
        num_steps --;
    }
    cursor.next = prev;
    cursor2.next = curr;
    
    return dummy.next;
};