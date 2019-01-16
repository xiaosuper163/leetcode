/**
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} head
 * @param {number} n
 * @return {ListNode}
 */
var removeNthFromEnd = function(head, n) {
    if (!head) {
        return head;
    }
    
    var prevHead = new ListNode(0);
    prevHead.next = head;
    var currNode = head;
    var listLength = 1;
    while (currNode.next) {
        listLength ++;
        currNode = currNode.next;
    }
    
    var targetIndex = listLength - n;
    currNode = prevHead;
    while(targetIndex>0) {
        currNode = currNode.next;
        targetIndex--;
    }
    
    currNode.next = currNode.next.next;
    
    return prevHead.next;
        
};