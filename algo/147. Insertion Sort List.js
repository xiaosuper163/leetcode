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
 * @return {ListNode}
 */
var insertionSortList = function(head) {
    var insert = function(toInsert) {
        var p1 = sortedStart;
        var p2 = sortedStart.next;
        while (p2 !== null && p2.val < toInsert.val) {
            p1 = p1.next;
            p2 = p2.next;
        }
        if (p1 === sortedEnd) {
            p1.next = toInsert;
            sortedEnd = toInsert;
        } else {
            p1.next = toInsert;
            toInsert.next = p2;
        }
    };
    if (head === null) {
        return head;
    }
    var dummy = new ListNode(-Infinity);
    dummy.next = head;
    var cursor = head;
    var sortedStart = dummy;
    var sortedEnd = dummy;
    
    while (cursor !== null) {
        var temp = cursor.next;
        cursor.next = null;
        insert(cursor, sortedStart, sortedEnd);
        cursor = temp;
    }
    return dummy.next;
};