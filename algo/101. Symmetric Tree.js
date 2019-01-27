/**
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @return {boolean}
 */
var isSymmetric = function(root) {
    var helper = function(left, right) {
        if (left===null && right!==null) {
            return false;
        } else if (left!==null && right===null) {
            return false;
        } else if (left===null && right===null) {
            return true;
        } else {
            if (left.val != right.val) {
                return false;
            } else {
                return helper(left.left, right.right) && helper(left.right, right.left);
            }
        }        
    };
    
    if (root == null) {
        return true;
    }
    
    return helper(root.left, root.right);
};