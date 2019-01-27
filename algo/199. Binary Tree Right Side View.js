// BFS

/**
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number[]}
 */
var rightSideView = function(root) {
    if (root == null) {
        return [];
    }
    
    res = [];
    var queue = [root];
    while (queue.length != 0) {
        var levelSize = queue.length;
        for (var i=0; i < levelSize; i++) {
            var currNode = queue.shift();
            if (i==levelSize-1) {
                res.push(currNode.val);
            }
            
            if (currNode.left) {
                queue.push(currNode.left);
            }
            
            if (currNode.right) {
                queue.push(currNode.right);
            }
        }        
    }
    
    return res;
};