// @9 Divide and Conquer
// Need subscription to unlock
// Lintcode 595

/**
 * @param root: the root of binary tree
 * @return: the length of the longest consecutive sequence path
 */
 
var helper = function(root) {
    if (root === null) {
        return 0;
    }
    
    if (root.left === null && root.right === null) {
        return 1;
    }
    
    var leftRes = helper(root.left);
    var rightRes = helper(root.right);
    
    var currLength = 1;
    
    if (root.right !== null && root.val+1 == root.right.val) {
        currLength = rightRes + 1;
    } else if (root.left !== null && root.val+1 == root.left.val) {
        currLength = leftRes + 1;
    }
    
    if (currLength > longestLength) {
        longestLength = currLength;
    }
    
    return currLength;
};
 
const longestConsecutive = function (root) {
    // write your code here
    longestLength = 0;  // global variable used to store the longest length
    helper(root);
    return longestLength;
}

