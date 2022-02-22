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

    // !!!!!! My solution here is way more complicated. Not recommended. Find the best answer in Round 2.
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        return Helper(root, p, q).LCA;
    }
    
    public HelperClass Helper(TreeNode root, TreeNode p, TreeNode q) {
        var ret = new HelperClass();
        
        // exit
        if (root == null) {
            return ret;
        }
        if (root.left == null && root.right == null) { // leaf            
            if (root.val == p.val) {
                ret.HasLeftAncestor = true;    
            } else if (root.val == q.val) {
                ret.HasRightAncestor = true;
            }            
            return ret;
        }
        
        // divide
        var leftRes = Helper(root.left, p, q);
        var rightRes = Helper(root.right, p, q);
        
        // merge
        if (leftRes.LCA != null) { // find answer in left subtree
            return leftRes;
        } else if (rightRes.LCA != null) { // find answer in right subtree
            return rightRes;
        } else if (((leftRes.HasLeftAncestor || root.val == p.val) && (rightRes.HasRightAncestor || root.val == q.val)) || ((leftRes.HasRightAncestor || root.val == q.val) && (rightRes.HasLeftAncestor || root.val == p.val))) {
            ret.HasLeftAncestor = true;
            ret.HasRightAncestor = true;
            ret.LCA = root;
        } else {          
            ret.HasLeftAncestor = leftRes.HasLeftAncestor || rightRes.HasLeftAncestor || root.val == p.val;
            ret.HasRightAncestor = leftRes.HasRightAncestor || rightRes.HasRightAncestor || root.val == q.val;
            ret.LCA = ret.HasLeftAncestor && ret.HasRightAncestor ? root : null;
        }
        return ret;
    }
}

public class HelperClass {
    public bool HasLeftAncestor {get; set;} = false;
    public bool HasRightAncestor {get; set;} = false;
    public TreeNode LCA {get; set;} = null;    
}
