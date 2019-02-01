

/**
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} l1
 * @param {ListNode} l2
 * @return {ListNode}
 */
var mergeTwoLists = function(l1, l2) {
    var dummy = new ListNode(0);
    var cursor = dummy;
    var cursor1 = l1;
    var cursor2 = l2;
    
    while (cursor1 !== null && cursor2 !== null) {
        if (cursor1.val < cursor2.val) {
            cursor.next = cursor1;
            cursor1 = cursor1.next;
        } else {
            cursor.next = cursor2;
            cursor2 = cursor2.next;
        }
        cursor = cursor.next;
    }
    if (cursor1===null) {
        cursor.next = cursor2;
    }
    if (cursor2===null) {
        cursor.next = cursor1;
    }
    return dummy.next;
};