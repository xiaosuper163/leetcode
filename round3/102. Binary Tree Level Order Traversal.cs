/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> ret = new List<IList<int>>();
        if (root == null) return ret;
        
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        
        while (q.Count != 0) {
            int size = q.Count;
            IList<int> level = new List<int>();
            for (int i=0; i<size; i++) {
                TreeNode node = q.Dequeue();
                level.Add(node.val);
                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
            }
            ret.Add(level);
        }
        
        return ret;
    }
}