"""
Definition for a Directed graph node
class DirectedGraphNode:
    def __init__(self, x):
        self.label = x
        self.neighbors = []
"""
from collections import deque

class Solution:
    """
    @param: graph: A list of Directed graph node
    @return: Any topological order for the given graph.
    """
    
    def topSort(self, graph):
        # write your code here
        if len(graph) == 0:
            return []
        
        # get the indegree of each node
        indegree = dict()
        for node in graph:
            indegree[node.label] = 0
        for node in graph:
            for neighbor in node.neighbors:
                indegree[neighbor.label] += 1
        print(indegree)
        queue = deque([]);
        # find the first node
        for node in graph:
            if indegree[node.label] == 0:
                queue.append(node)
                # do not break here
                # there might be more than one node with indegree of 0
        
        res = []
        # bfs
        while len(queue) != 0:
            node = queue.popleft()
            res.append(node)
            for neighbor in node.neighbors:
                indegree[neighbor.label] -= 1
                if indegree[neighbor.label] == 0:
                    queue.append(neighbor)
                    
        return res