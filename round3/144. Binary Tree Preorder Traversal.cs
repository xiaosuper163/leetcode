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
    public IList<int> PreorderTraversal(TreeNode root) {        
        var res = new List<int>();
        if (root == null) return res;
        var st = new Stack<TreeNode>();
        st.Push(root);
        while (st.Count != 0) {
            TreeNode curr = st.Pop();
            res.Add(curr.val);
            
            if (curr.right != null) st.Push(curr.right);
            if (curr.left != null) st.Push(curr.left);
        }
        
        return res;
    }
}