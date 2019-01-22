# @9 BFS
# need subscription to unlock

class Solution:
    """
    @param n: An integer
    @param edges: a list of undirected edges
    @return: true if it's a valid tree, or false
    """
    def validTree(self, n, edges):
        from collections import deque
        # write your code here
        # no nodes at all
        if n == 0:
            return False
        
        # only one node, no edges    
        if len(edges) == 0 and n == 1:
            return True
        
        # tree: # of edges = # of nodes - 1   
        if len(edges) != n - 1:
            return False
        
        tree = dict()
        for i in range(n):
            tree[i] = []
        for edge in edges:
            tree[edge[0]].append(edge[1])
            tree[edge[1]].append(edge[0])
        
        is_visited = [False for _ in range(n)]
        queue = deque([edges[0][0]])
        num_visited = 0
        
        while len(queue) != 0:
            currNode = queue.popleft()
            is_visited[currNode] = True
            num_visited += 1
            for neighbor in tree[currNode]:
                # make sure a-b b-a only be counted once
                if is_visited[neighbor] == True:
                    continue
                is_visited[neighbor] = True
                queue.append(neighbor)
        return num_visited == n
