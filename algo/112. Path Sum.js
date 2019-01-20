// @9 Divide and Conquer

/**
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @param {number} sum
 * @return {boolean}
 */

var hasPathSum = function(root, sum) {
    
    // if it is the child of leaf, return false
    if (root == null) {
        return false;
    }
    
    // if it is the leaf, check the value
    if (root.left==null && root.right==null) {
        if (root.val == sum) {
            return true;
        } else {
            return false;
        }
    }
    
    // split
    var leftRes = hasPathSum(root.left, sum-root.val);
    var rightRes = hasPathSum(root.right, sum-root.val);
    
    // merge
    if (leftRes || rightRes) {
        return true;
    }
    
    return false;
};