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
    
    if (root == null) {
        return undefined;
    }
    
    // true or false, max, min
    if (root.left == null && root.right == null) {
        return [true, root.val, root.val];
    }
    
    var leftRes = helper(root.left);
    var rightRes = helper(root.right);
    
    if (root.left == null) {
        if (root.val < rightRes[2] && rightRes[0] == true) {
            return [true, rightRes[1], root.val];
        }
    } else if (root.right == null) {
        if (root.val > leftRes[1] && leftRes[0] == true) {
            return [true, root.val, leftRes[2]];
        }
    } else {
        if (root.val < rightRes[2] && root.val > leftRes[1] && rightRes[0] == true && rightRes[0] == true) {
            return [true, rightRes[1], leftRes[2]];
        }
    }

    return [false];
}

var isValidBST = function(root) {
    if (root==null) {
        return true;
    }
    return helper(root)[0];
};