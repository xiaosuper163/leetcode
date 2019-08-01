/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node(){}
    public Node(int _val,IList<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
}
*/
public class Solution {
    private void Helper(Node node, Dictionary<int, Node> mappings) {
        if (mappings.ContainsKey(node.val)) return;
        Node clonedNode = new Node(node.val, new List<Node>());
        mappings[node.val] = clonedNode;
        foreach(var neighbor in node.neighbors) {
            Helper(neighbor, mappings);
        }
    }
    
    private void BuildNeighbors(Node node, Dictionary<int, Node> mappings, HashSet<int> visited) {
        foreach(var neighbor in node.neighbors) {
            visited.Add(node.val);
            mappings[node.val].neighbors.Add(mappings[neighbor.val]);
            if (!visited.Contains(neighbor.val)) {
                BuildNeighbors(neighbor, mappings, visited);
            }
        }
    }
    
    public Node CloneGraph(Node node) {
        if (node == null) return null;
        var mappings = new Dictionary<int, Node>();
        var visited = new HashSet<int>();
        Helper(node, mappings);
        BuildNeighbors(node, mappings, visited);
        return mappings[node.val];
    }
}