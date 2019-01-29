// @9 Linked List

/**
 * Definition for singly-linked list with a random pointer.
 * function RandomListNode(label) {
 *     this.label = label;
 *     this.next = this.random = null;
 * }
 */

/**
 * @param {RandomListNode} head
 * @return {RandomListNode}
 */
var copyRandomList = function(head) {
    // interweaving
    // 1. create new nodes
    if (head === null) {
        return null;
    }
    var cursor = head;
    while (cursor !== null) {
        var prime = new RandomListNode(cursor.label);
        var temp = cursor.next;
        cursor.next = prime;
        prime.next = temp;
        cursor = temp;
    }
    // 2. set random pointer
    cursor = head;
    while (cursor !== null) {
        if (cursor.random === null) {
            cursor.next.random = null;
        } else {
            cursor.next.random = cursor.random.next;    
        }
        cursor = cursor.next.next;
    }
    // 3. split
    cursor = head;
    ans = cursor.next;
    while (cursor !== null) {
        var temp = cursor.next;
        cursor.next = cursor.next.next;
        if (cursor.next === null) {
            temp.next = null;
        } else {
            temp.next = cursor.next.next;
        }
        cursor = cursor.next;
    }
    return ans;
};