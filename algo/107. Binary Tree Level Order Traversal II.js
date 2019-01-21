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
var levelOrderBottom = function(root) {
    if (root == null) {
        return [];
    }
    
    var res = [];
    var queue = [root];
    while (queue.length != 0) {
        var levelRes = [];
        var levelSize = queue.length;

        for (var i=0; i<levelSize; i++) {
            let currNode = queue.shift();
            levelRes.push(currNode.val);
            if (currNode.left) {
                queue.push(currNode.left);
            }

            if (currNode.right) {
                queue.push(currNode.right);
            }
        }

        res.unshift(levelRes);
    }
    
    return res;
};