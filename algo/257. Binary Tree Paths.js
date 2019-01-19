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
 * @return {string[]}
 */
var binaryTreePaths = function(root) {
    
    // child of leaf
    if (root == null) {
        return [];
    }
    
    // we need to do something for leaf
    // since the resulted string is different for leaf
    // eg. "1->2->3". there is no "->" at the end 
    if (root.left == null && root.right == null) {
        return [root.val + ""];
    }
    
    // initialize parameters or utilities
    var res = [];
    
    // divide
    var leftPaths = binaryTreePaths(root.left);
    var rightPaths = binaryTreePaths(root.right);
    
    // merge
    for (var i = 0; i < leftPaths.length; i++) {
        res.push(root.val + "->" + leftPaths[i]);
    }

    for (var i = 0; i < rightPaths.length; i++) {
        res.push(root.val + "->" + rightPaths[i]);
    }
  
    return res;
};