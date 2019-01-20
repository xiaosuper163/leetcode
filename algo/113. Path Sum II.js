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
 * @return {number[][]}
 */

var pathSum = function(root, sum) {
    // if it is the child of leaf, return false
    if (root == null) {
        return [];
    }
    
    // if it is the leaf, check the value
    if (root.left==null && root.right==null) {
        if (root.val == sum) {
            return [[root.val]];
        } else {
            return [];
        }
    }
    
    // split
    var leftRes = pathSum(root.left, sum-root.val);
    var rightRes = pathSum(root.right, sum-root.val);
    
    // merge
    var res = [];
    
    if (leftRes) {
        for (var i=0; i<leftRes.length; i++) {
            var tempRes = leftRes[i];
            tempRes.unshift(root.val);
            res.push(tempRes);
        }
    }
    
    if (rightRes) {
        for (var i=0; i<rightRes.length; i++) {
            var tempRes = rightRes[i];
            tempRes.unshift(root.val);
            res.push(tempRes);
        }
    }
    return res;
};