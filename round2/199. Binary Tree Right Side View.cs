/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<int> RightSideView(TreeNode root) {
        var queue = new Queue<TreeNode>();
        var res = new List<int>();
        if (root == null) return res;
        queue.Enqueue(root);
        while (queue.Count != 0) {
            int levelSize = queue.Count;
            for (int i=0; i<levelSize; i++) {
                var curr = queue.Dequeue();
                if (i == levelSize - 1) res.Add(curr.val);
                if (curr.left != null) queue.Enqueue(curr.left);
                if (curr.right != null) queue.Enqueue(curr.right);
            }
        }
        return res;
    }
}