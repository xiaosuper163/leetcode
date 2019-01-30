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
 * @return {ListNode}
 */
var detectCycle = function(head) {
    var tortois = head;
    var rabbit = head;
    var cursor = head;
    var ans = 0
    while (rabbit !== null && rabbit.next !== null) {
        tortois = tortois.next;
        rabbit = rabbit.next.next;
        if (tortois === rabbit) {
            while (cursor !== tortois) {
                cursor = cursor.next;
                tortois = tortois.next;
                ans++;
            }
            return cursor;
        }
    }
    return null;
};