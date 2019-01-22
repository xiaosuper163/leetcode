// @9 BFS

/**
 * Definition for undirected graph.
 * function UndirectedGraphNode(label) {
 *     this.label = label;
 *     this.neighbors = [];   // Array of UndirectedGraphNode
 * }
 */

/**
 * @param {UndirectedGraphNode} graph
 * @return {UndirectedGraphNode}
 */
var cloneGraph = function(graph) {
    
    if (graph == null) {
        return null;
    }
    
    // find all the nodes by using dfs first
    
    // !!!!!! it is of vital importance to use set here!
    var nodes = new Set([graph]);
    var queue = [graph];
    while (queue.length != 0) {
        var currNode = queue.shift();
        for (var neighbor of currNode.neighbors) {
            // if we have already visited this node
            if (!nodes.has(neighbor)) {
                nodes.add(neighbor);
                queue.push(neighbor);
            }
        }
    }
    
    // record the mapping relationships between the original nodes and newly created nodes
    var org2new = {};
    for (var node of nodes) {
        org2new[node.label] = new UndirectedGraphNode(node.label);
    }    
    
    // copy the neighbor relationships between the nodes in the graph
    for (var node of nodes) {
        for (var neighbor of node.neighbors) {
            
            org2new[node.label].neighbors.push(org2new[neighbor.label]);
        }
    }

    return org2new[graph.label];
};