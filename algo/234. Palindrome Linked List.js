// O(1) space O(n) time

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
var isPalindrome = function(head) {
    if (head === null || head.next === null) {
        return true;
    }
    var dummy = new ListNode(0);
    dummy.next = head;
    var tortois = dummy;
    var rabbit = dummy;
    while (rabbit !== null && rabbit.next !== null) {
        tortois = tortois.next;
        rabbit = rabbit.next.next;
    }
    // reverse the order of the second half
    var p1 = null;
    var p2 = tortois.next;
    while (p2 !== null) {
        var temp = p2.next;
        p2.next = p1;
        p1 = p2;
        p2 = temp;
    }
    // compare the first half and second half
    var ans = true;
    var c1 = dummy.next;
    var c2 = p1;
    while (c2 !== null) {
        if (c1.val !== c2.val) {
            ans = false;
            break;
        }
        c1 = c1.next;
        c2 = c2.next;
    }
    // restore the linked list
    while (p1 !== null) {
        var temp = p1.next;
        p1.next = p2;
        p2 = p1;
        p1 = temp;
    }
    tortois.next = p2;
    // return ans
    return ans;
};