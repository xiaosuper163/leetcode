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
 * @return {number}
 */
var maxDepth = function(root) {
    if (root == undefined || root == null) {
        return 0;
    }
        
    var leftMaxDepth = maxDepth(root.left);
    var rightMaxDepth = maxDepth(root.right);
    
    return Math.max(leftMaxDepth, rightMaxDepth) + 1;
};