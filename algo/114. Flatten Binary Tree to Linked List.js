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
 * @return {void} Do not return anything, modify root in-place instead.
 */

var helper = function(root) {
    var head, bottom;
    if (root.left == null && root.right == null) {
        head = root;
        bottom = root;
    } else if (root.left != null && root.right != null) {
        var leftRes = helper(root.left);
        var rightRes = helper(root.right);
        root.left = null;
        root.right = leftRes[0];
        leftRes[1].right = rightRes[0];
        head = root;
        bottom = rightRes[1];
    } else if (root.left == null && root.right != null) {
        var rightRes = helper(root.right);
        head = root;
        bottom = rightRes[1];
    } else {
        var leftRes = helper(root.left);
        head = root;
        root.left = null;
        root.right = leftRes[0];
        bottom = leftRes[1];
    }
    
    return [head, bottom];
}

var flatten = function(root) {
    if (root == null) {
        return null;
    }
    
    return helper(root)[0];
};