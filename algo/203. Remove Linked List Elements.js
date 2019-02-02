/**
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} head
 * @param {number} val
 * @return {ListNode}
 */
var removeElements = function(head, val) {
    var dummy = new ListNode(0);
    dummy.next = head;
    var cursor = dummy;
    while (cursor !== null && cursor.next !== null) {
        if (cursor.next.val == val) {
            cursor.next = cursor.next.next;
        } else {
            cursor = cursor.next;
        }
    }
    return dummy.next;
};