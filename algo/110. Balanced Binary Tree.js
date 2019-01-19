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
 * @return {boolean}
 */

var helper = function(root) {
    if (root==null) {
        return [0, true];
    }
        
    var leftRes = helper(root.left);
    var rightRes = helper(root.right);
    
    var isBalancedFlag = false;
    
    if (leftRes[1] && rightRes[1] && Math.abs(leftRes[0]-rightRes[0])<=1) {
        isBalancedFlag = true;
    }

    return [Math.max(leftRes[0], rightRes[0])+1, isBalancedFlag];
};

var isBalanced = function(root) {
    return helper(root)[1];
};

