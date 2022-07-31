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
    public IList<int> PostorderTraversal(TreeNode root) {
        var res = new List<int>();
        if (root == null) return res;
        
        TreeNode lastProcessed = root;
        var st = new Stack<TreeNode>();
        st.Push(root);
        while (st.Count != 0) {
            TreeNode curr = st.Peek();
            if ((curr.left == null && curr.right == null) || curr.left == lastProcessed || curr.right == lastProcessed) {
                res.Add(curr.val);
                lastProcessed = curr;
                st.Pop();
            } else {
                if (curr.right != null) st.Push(curr.right);
                if (curr.left != null) st.Push(curr.left);    
            }            
        }
        
        return res;
    }
}