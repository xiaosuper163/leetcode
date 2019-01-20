// Divide and Conquer

/**
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @param {TreeNode} p
 * @param {TreeNode} q
 * @return {TreeNode}
 */
var lowestCommonAncestor = function(root, p, q) {
    if (root == null) {
        return null;
    }
    
    if (root == p) {
        return p;
    }
    
    if (root == q) {
        return q;
    }
    
    if (root.left == null && root.right == null) {
        return null;
    }
    
    var leftRes = lowestCommonAncestor(root.left, p, q);
    var rightRes = lowestCommonAncestor(root.right, p, q);
    
    //console.log('leftRes', leftRes, 'rightRes', rightRes)
    
    if (leftRes==null && rightRes == null) {            // nothing in lhs, nothing in rhs
        return null;                                
    } else if (leftRes==null || rightRes==null) {       // something in either lhs or rhs
        return leftRes==null ? rightRes : leftRes;
    } else {                                            // p in lhs, q in rhs or the other way
        return root;
    }
};