// @9 BFS

/**
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */

/**
 * Encodes a tree to a single string.
 *
 * @param {TreeNode} root
 * @return {string}
 */
var serialize = function(root) {
    if (root == null) {
        return "[]";
    }
    
    var res = [];
    var queue = [root];
    while (queue.length != 0) {
        var currNode = queue.shift();
        if (currNode == null) {
            res.push(null);
            continue;
        }
        res.push(currNode.val);

        queue.push(currNode.left);
        queue.push(currNode.right);
    }
    // remove the null at the end
    while (res[res.length-1] == null) {
        res.pop();
    }
    
    var resStr = "[";
    for (var i=0; i<res.length; i++) {
        resStr += String(res[i]) + ",";
    }
    resStr = resStr.slice(0,resStr.length-1) + "]";
    //console.log(resStr);
    return resStr;
};

/**
 * Decodes your encoded data to tree.
 *
 * @param {string} data
 * @return {TreeNode}
 */
var deserialize = function(data) {
    if (data === "[]") {
        return null;
    }
    
    var strList = data.slice(1,data.length-1).split(",");
    //console.log(strList);
    var root = new TreeNode(parseInt(strList[0]));
    var queue = [root];
    var index = 0;
    var isLeftNode = true;
    for (var i = 1; i < strList.length; i++) {
        if (strList[i] === "null") {
            ;
        } else if (isLeftNode) {
            var currNode = new TreeNode(parseInt(strList[i]));
            queue[index].left = currNode;
            queue.push(currNode);
        } else {
            var currNode = new TreeNode(parseInt(strList[i]));
            queue[index].right = currNode;
            queue.push(currNode);
        }
        
        if (!isLeftNode) {
            index ++;
        }
        isLeftNode = !isLeftNode;
    }
    return root;
};

/**
 * Your functions will be called as such:
 * deserialize(serialize(root));
 */