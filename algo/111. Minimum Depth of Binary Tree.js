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
 * @return {number}
 */
var minDepth = function(root) {
    if (root === null) {
        return 0;
    }
    
    var queue = [root];
    var levelIndex = 1;
    while (queue.length != 0) {
        var levelSize = queue.length;
        for (var i = 0; i < levelSize; i ++) {
            var currNode = queue.shift();
            if (currNode.left === null && currNode.right === null) {
                return levelIndex;
            }
            if (currNode.left) {
                queue.push(currNode.left);
            }
            if (currNode.right) {
                queue.push(currNode.right);
            }
        }
        levelIndex++;
    }
    
};