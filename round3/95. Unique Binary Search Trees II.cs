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
    public IList<TreeNode> GenerateTrees(int n) {
        return Helper(1, n);
    }
    
    private IList<TreeNode> Helper(int left, int right) {
        var res = new List<TreeNode>();
        
        if (left > right) return new List<TreeNode>() {null};
                
        for (int i = left; i <= right; i++) {
            var leftRes = Helper(left, i - 1);
            var rightRes = Helper(i + 1, right);       
            
            foreach (TreeNode l in leftRes) {
                foreach (TreeNode r in rightRes) {
                    var head = new TreeNode(i);
                    head.left = l;
                    head.right = r;
                    res.Add(head);
                }
            }
        }
        
        return res;
    }
}