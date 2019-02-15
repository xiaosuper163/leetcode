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
 * @return {void} Do not return anything, modify head in-place instead.
 */
var reorderList = function(head) {
    if (head === null) {
        return;
    }
    // find the middle
    var tortois = head;
    var rabbit = head;
    while (rabbit != null && rabbit.next != null) {
        tortois = tortois.next;
        rabbit = rabbit.next.next;
    }
    // cut the middle and reverse the second half
    var p1 = tortois;
    var p2 = tortois.next;
    tortois.next = null;
    while (p2 !== null) {
        var temp = p2.next;
        p2.next = p1;
        p1 = p2;
        p2 = temp;
    }
    // reorder the whole linked list
    cursor1 = head;
    cursor2 = p1;
    while (cursor2 !== null && cursor1.next !== cursor2) {
        var temp = cursor1.next;
        var temp2 = cursor2.next;
        cursor1.next = cursor2;
        cursor2.next = temp;
        cursor1 = cursor2.next;
        cursor2 = temp2;
    }
};