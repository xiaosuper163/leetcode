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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        var q = new Queue<TreeNode>();
        var res = new List<IList<int>>();
        if (root == null) return res;
        q.Enqueue(root);
        bool oddLevel = true;
        
        while (q.Count != 0) {
            int levelCount = q.Count;
            List<int> levelRes = new List<int>(); 
            // Declare levelRes as IList won't work. 
            // IList uses extension method for reverse.
            // And it operates on IEnumerable which is not writable
            for (int i = 0; i < levelCount; i ++) {
                TreeNode curr = q.Dequeue();
                levelRes.Add(curr.val);
                
                if (curr.left != null) q.Enqueue(curr.left);
                if (curr.right != null) q.Enqueue(curr.right);
            }
            if (!oddLevel) {
                levelRes.Reverse();
            }
            oddLevel = !oddLevel;
            res.Add(levelRes);
        }
        return res;
    }
}