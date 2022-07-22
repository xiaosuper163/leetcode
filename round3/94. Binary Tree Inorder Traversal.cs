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
// public class Solution {
//     public IList<int> InorderTraversal(TreeNode root) {
//         var res = new List<int>();
//         Helper(root, res);
//         return res;
//     }
    
//     private void Helper(TreeNode root, IList<int> res) {
//         if (root == null) return;
//         Helper(root.left, res);
//         res.Add(root.val);
//         Helper(root.right, res);
//     }
// }

public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        var st = new Stack<TreeNode>();
        var res = new List<int>();
        
        TreeNode curr = root;
        
        while (curr != null || st.Count != 0) {
            while (curr != null) {
                st.Push(curr);
                curr = curr.left;
            }
            
            curr = st.Pop();
            res.Add(curr.val);
            curr = curr.right;
        }
        return res;
    }
}