// BFS, topological sort

/**
 * @param {number} numCourses
 * @param {number[][]} prerequisites
 * @return {boolean}
 */
var canFinish = function(numCourses, prerequisites) {
    if (prerequisites.length == 0) {
        return true;
    }
    var edges = {};         // used to store the edges
    var indegree = {};      // used to store the source
    for (prerequisite of prerequisites) {
        if (!edges.hasOwnProperty(prerequisite[0])) {
            edges[prerequisite[0]] = [prerequisite[1]];
        } else {
            edges[prerequisite[0]].push(prerequisite[1]);
        }
        if (!indegree.hasOwnProperty(prerequisite[1])) {
            indegree[prerequisite[1]] = 1;
        } else {
            indegree[prerequisite[1]] += 1;
        }
    }
    var queue = [];
    var numReachableCourses = 0;
    for (var i=0; i<numCourses; i++) {
        if (!indegree.hasOwnProperty(i)) {
            queue.push(i);
        }
    }
    if (queue.length == 0) {
        return false;
    }
    while (queue.length != 0) {
        var currNode = queue.shift();
        numReachableCourses++;
        // if it is a leaf
        if(!edges.hasOwnProperty(currNode)) {
            continue;
        }
        var neighbors = edges[currNode];
        for (var i=0; i<neighbors.length; i++) {
            var neighbor = neighbors[i];
            // when indegree of the node is 0, the course can be taken
            if (--indegree[neighbor] == 0) {
                queue.push(neighbor);
            }
        }
    }
    return numReachableCourses == numCourses;
};