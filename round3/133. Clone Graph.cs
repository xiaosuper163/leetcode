/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if (node == null) return node;
        
        // iterate
        IList<Node> nodes = BFS(node);
        
        List<Node> clonedNodes = new List<Node>();
        Dictionary<Node, Node> map = new Dictionary<Node, Node>();
        
        // clone nodes
        foreach (Node currNode in nodes) {
            Node clonedNode = new Node(currNode.val, new List<Node>());
            clonedNodes.Add(clonedNode);
            map[currNode] = clonedNode;
        }
                
        // clone edges
        foreach (Node currNode in nodes) {
            foreach (Node neighbor in currNode.neighbors) {
                map[currNode].neighbors.Add(map[neighbor]);
            }
        }
        
        return clonedNodes[0];
    }
    
    private IList<Node> BFS(Node node) {
        List<Node> ret = new List<Node>();
        Queue<Node> q = new Queue<Node>();
        HashSet<Node> visited = new HashSet<Node>();
        
        q.Enqueue(node);
        
        while (q.Count != 0) {
            Node currNode = q.Dequeue();
            if (visited.Contains(currNode)) continue;
            
            ret.Add(currNode);
            visited.Add(currNode);
            
            foreach (Node neighbor in currNode.neighbors) {
                if (!visited.Contains(neighbor)) {
                    q.Enqueue(neighbor);
                }
            }
        }
                
        return ret;
    }
}