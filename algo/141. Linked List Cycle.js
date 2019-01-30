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
 * @return {boolean}
 */
var hasCycle = function(head) {
    var tortois = head;
    var rabbit = head;
    while (rabbit !== null && rabbit.next !== null) {
        tortois = tortois.next;
        rabbit = rabbit.next.next;
        if (tortois === rabbit) {
            return true;
        }
    }
    return false;
};