/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    private void AddListNodeToSD(SortedDictionary<int, List<ListNode>> sd, ListNode listHead) {
        if (sd.ContainsKey(listHead.val)) {
            sd[listHead.val].Add(listHead);
        } else {
            sd[listHead.val] = new List<ListNode>() {listHead};
        }
    }
    public ListNode MergeKLists(ListNode[] lists) {
        var dummy = new ListNode(0);
        if (lists.Length == 0) return null;
        ListNode cursor = dummy;
        var sd = new SortedDictionary<int, List<ListNode>>();
        for (int i=0; i<lists.Length; i++) {
            ListNode listHead = lists[i];
            if (listHead != null) {
                AddListNodeToSD(sd, listHead);    
            }
        }
        while (sd.Count != 0) {
            var key = sd.Keys.Min();
            var tmpList = sd[key];
            sd.Remove(key);
            foreach (ListNode ln in tmpList) {
                cursor.next = ln;
                cursor = cursor.next;
                if (ln.next != null) {
                    AddListNodeToSD(sd, ln.next);
                }
            }
        }
        cursor.next = null;
        return dummy.next;
    }
}