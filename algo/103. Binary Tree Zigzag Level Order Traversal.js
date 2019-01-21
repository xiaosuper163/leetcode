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
 * @return {number[][]}
 */
var zigzagLevelOrder = function(root) {
    if (root == null) {
        return [];
    }
    
    var res = [];
    var queue = [root];
    var levelIndex = 1;
    while (queue.length != 0) {
        var levelRes = [];
        var levelSize = queue.length;

        for (var i=0; i<levelSize; i++) {
            let currNode = queue.shift();
            
            // use stack for odd line, use queue for even line
            if (levelIndex % 2 == 1) {
                levelRes.push(currNode.val);
            } else {
                levelRes.unshift(currNode.val);
            }            
            if (currNode.left) {
                queue.push(currNode.left);
            }

            if (currNode.right) {
                queue.push(currNode.right);
            }
        }
        
        levelIndex ++;
        res.push(levelRes);
    }
    
    return res;
};