// @9 Linked List

/**
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */

/**
 * @param {ListNode} headA
 * @param {ListNode} headB
 * @return {ListNode}
 */
var getIntersectionNode = function(headA, headB) {
    if (headA === null || headB === null) {
        return null;
    }
    var cursor = headA;
    while(cursor.next !== null) {
        cursor = cursor.next;
    }
    var breakpoint = cursor;
    cursor.next = headB;
    var tortois = headA;
    var rabbit = headA;
    cursor = headA;
    while (rabbit !== null && rabbit.next !== null) {
        tortois = tortois.next;
        rabbit = rabbit.next.next;
        if (tortois === rabbit) {
            while (cursor !== tortois) {
                cursor = cursor.next;
                tortois = tortois.next;
            }
            breakpoint.next = null;
            return cursor;
        }
    }
    breakpoint.next = null;
    return null;
};