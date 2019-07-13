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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        List<IList<int>> res = new List<IList<int>>();
        if (root == null) return res;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        bool isOddLevel = true;
        while(queue.Count != 0) {
            var levelRes = new List<int>();
            int levelSize = queue.Count;
            for (int i=0; i<levelSize; i++) {
                TreeNode curr = queue.Dequeue();
                levelRes.Add(curr.val);
                if (curr.left != null) queue.Enqueue(curr.left);
                if (curr.right != null) queue.Enqueue(curr.right);
            }
            if (!isOddLevel) levelRes.Reverse();
            res.Add(levelRes);
            isOddLevel = !isOddLevel;
        }
        return res;
    }
}